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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        GörselEntities db;

        void doldur()  //Verileri Çekme  (Select)
        {
            db = new GörselEntities();
            dataGridView1.DataSource = (from x in db.OkulYönetimi
                                        select new
                                        {
                                            x.ID,
                                            x.Ad_Soyad,
                                            x.Görevi,
                                            x.Görev_Tipi,

                                        }).ToList();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            doldur();  

        }

        private void Ekle_buton_Click(object sender, EventArgs e)
        {
            OkulYönetimi yenioyönetim = new OkulYönetimi();
            yenioyönetim.ID = Convert.ToInt32(textBox1.Text);
            yenioyönetim.Ad_Soyad = textBox5.Text;
            yenioyönetim.Görevi = textBox4.Text;
            yenioyönetim.Görev_Tipi = textBox3.Text;
            db.OkulYönetimi.Add(yenioyönetim);
            db.SaveChanges();
            doldur();

            textBox1.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox5.Clear();

            MessageBox.Show("Yeni Okul İdare Personeli Eklendi");
        }

        private void Sil_buton_Click(object sender, EventArgs e)
        {
            int silinecek = Convert.ToInt32(textBox1.Text);
            var silinecekkisi = db.OkulYönetimi.Where(w => w.ID == silinecek).FirstOrDefault();
            db.OkulYönetimi.Remove(silinecekkisi);
            db.SaveChanges();
            dataGridView1.DataSource = db.OkulYönetimi.ToList();

            textBox1.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox5.Clear();

            MessageBox.Show("Okul İdare Personeli Silindi");
        }

        private void Güncelle_buton_Click(object sender, EventArgs e)
        {
            int guncelle = Convert.ToInt32(textBox1.Text);
            var guncellenecekkişi = db.OkulYönetimi.Where(w => w.ID == guncelle).FirstOrDefault();
            guncellenecekkişi.Ad_Soyad = textBox5.Text;
            guncellenecekkişi.Görevi = textBox4.Text;
            guncellenecekkişi.Görev_Tipi = textBox3.Text;
            db.SaveChanges();
            doldur();

            textBox1.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox5.Clear();

            MessageBox.Show("Okul İdare Personeli Güncellendi");
        }

        private void Ara_txt_TextChanged(object sender, EventArgs e)
        {
            string aranan = Ara_txt.Text;
            var degerler = from item in db.OkulYönetimi
                           where item.Ad_Soyad.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
        }
    }
}
