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
using System.Data.SqlClient;
using System.Configuration;

namespace Görsel_Vize
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        GörselEntities db = new GörselEntities();
        public int Ders_ID { get; private set; }
        public int Öğrenci_ID { get; private set; }

        void doldur()  //Verileri Çekme  (Select)
        {
            db = new GörselEntities();
            dataGridView1.DataSource = (from x in db.ÖDers
                                        select new
                                        {
                                            x.ID,
                                            x.Öğrenci.Ad_Soyad,
                                            x.YönetimDers.Ders_Adı,

                                        }).ToList();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Ders_Adı";
            comboBox1.ValueMember = "ID";

            comboBox2.DisplayMember = "Ad_Soyad";
            comboBox2.ValueMember = "ID";

            comboBox1.DataSource = db.YönetimDers.ToList();
            comboBox2.DataSource = db.Öğrenci.ToList();
            doldur();
        }

        private void Ekle_buton_Click(object sender, EventArgs e)
        {
            ÖDers ogrdrs = new ÖDers
            {
                Ders_ID = int.Parse(comboBox1.SelectedValue.ToString()),
                Öğrenci_ID = int.Parse(comboBox2.SelectedValue.ToString())
            };
            db.ÖDers.Add(ogrdrs);

            db.SaveChanges();
            MessageBox.Show("Öğrenciye Ders Eklendi");

        }

        private void Sil_buton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ogrdrs = db.ÖDers.Find(x);

            db.ÖDers.Remove(ogrdrs);
            db.SaveChanges();

            MessageBox.Show("Yönetici Silindi");
            MessageBox.Show("Öğrencinin Dersi Silindi");
        }

        private void Güncelle_buton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ogrdrs = db.ÖDers.Find(x);

            ogrdrs.Ders_ID = int.Parse(comboBox1.SelectedValue.ToString());
            ogrdrs.Öğrenci_ID = int.Parse(comboBox2.SelectedValue.ToString());

            db.SaveChanges();
            MessageBox.Show("Öğrencinin Dersi Güncellendi");
        }

        private void Ara_txt_TextChanged(object sender, EventArgs e)
        {
            string aranan = Ara_txt.Text;
            var degerler = from item in db.ÖDers
                           where item.Öğrenci_ID.ToString(). Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
        }

        
    }
}
