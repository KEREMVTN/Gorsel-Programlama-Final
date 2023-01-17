using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Görsel_Vize
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        GörselEntities db;

        void doldur()  //Verileri Çekme  (Select)
        {
            db = new GörselEntities();
            dataGridView1.DataSource = (from x in db.YönetimDers
                                        select new
                                        {
                                            x.ID,
                                            x.Ders_Adı,
                                            x.Ders_Kredisi,
                                            x.Okul_Yönetim_ID,

                                        }).ToList();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void Ekle_buton_Click(object sender, EventArgs e)
        {
            YönetimDers yeniyders = new YönetimDers();
            yeniyders.ID = Convert.ToInt32(textBox1.Text);
            yeniyders.Ders_Adı = textBox5.Text;
            yeniyders.Ders_Kredisi = textBox4.Text;
            yeniyders.Okul_Yönetim_ID = Convert.ToInt32(textBox3.Text);
            db.YönetimDers.Add(yeniyders);
            db.SaveChanges();
            doldur();

            textBox1.Clear();
            textBox5.Clear();
            textBox3.Clear();
            textBox4.Clear();

            MessageBox.Show("Yeni Ders Eklendi");
        }

        private void Sil_buton_Click(object sender, EventArgs e)
        {
            int silinecek = Convert.ToInt32(textBox1.Text);
            var silinecekders = db.YönetimDers.Where(w => w.ID == silinecek).FirstOrDefault();
            db.YönetimDers.Remove(silinecekders);
            db.SaveChanges();
            dataGridView1.DataSource = db.YönetimDers.ToList();

            textBox1.Clear();
            textBox5.Clear();
            textBox3.Clear();
            textBox4.Clear();

            MessageBox.Show("Ders Silindi");
        }

        private void Güncelle_buton_Click(object sender, EventArgs e)
        {
            int guncelle = Convert.ToInt32(textBox1.Text);
            var guncellenecekyders = db.YönetimDers.Where(w => w.ID == guncelle).FirstOrDefault();
            guncellenecekyders.Ders_Adı = textBox5.Text;
            guncellenecekyders.Ders_Kredisi = textBox4.Text;
            guncellenecekyders.Okul_Yönetim_ID = Convert.ToInt32(textBox3.Text);
            db.SaveChanges();
            doldur();

            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            MessageBox.Show("Ders Güncellendi");
        }

        private void Ara_txt_TextChanged(object sender, EventArgs e)
        {
            string aranan = Ara_txt.Text;
            var degerler = from item in db.YönetimDers
                           where item.Ders_Adı.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
        }

    }
}
