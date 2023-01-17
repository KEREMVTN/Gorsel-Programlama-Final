using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görsel_Vize
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        GörselEntities db;

        void doldur()  //Verileri Çekme  (Select)
        {
            db = new GörselEntities();
            dataGridView1.DataSource = (from x in db.Öğrenci
                                        select new
                                        {
                                            x.ID,
                                            x.Ad_Soyad,
                                            x.Kayıt_Tarihi,
                                            x.Öğrenci_No,
                                            x.Doğum_Tarihi,
                                            x.Bölüm,

                                        }).ToList();
        }

        private void Ekle_buton_Click(object sender, EventArgs e)
        {
            Öğrenci yeniögrenci = new Öğrenci();
            yeniögrenci.ID = Convert.ToInt32(textBox1.Text);
            yeniögrenci.Ad_Soyad = textBox2.Text;
            yeniögrenci.Kayıt_Tarihi = textBox3.Text;
            yeniögrenci.Öğrenci_No = textBox4.Text;
            yeniögrenci.Doğum_Tarihi = Convert.ToDateTime(textBox5.Text);
            yeniögrenci.Bölüm = textBox6.Text;
            db.Öğrenci.Add(yeniögrenci);
            db.SaveChanges();
            doldur();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            MessageBox.Show("Yeni Öğrenci Kayıdı Eklendi");

        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void Güncelle_buton_Click(object sender, EventArgs e)
        {

            int guncelle = Convert.ToInt32(textBox1.Text);
            var guncellenecekogrenci = db.Öğrenci.Where(w => w.ID == guncelle).FirstOrDefault();
            guncellenecekogrenci.Ad_Soyad = textBox2.Text;
            guncellenecekogrenci.Kayıt_Tarihi = textBox3.Text;
            guncellenecekogrenci.Öğrenci_No = textBox4.Text;
            guncellenecekogrenci.Doğum_Tarihi = Convert.ToDateTime(textBox5.Text);
            guncellenecekogrenci.Bölüm = textBox6.Text;
            db.SaveChanges();
            doldur();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            MessageBox.Show("Öğrenci Kayıdı Güncellendi");
        }

   
        private void Sil_buton_Click(object sender, EventArgs e)
        {
            int silinecek = Convert.ToInt32(textBox1.Text);
            var silinecekkisi = db.Öğrenci.Where(w => w.ID == silinecek).FirstOrDefault();
            db.Öğrenci.Remove(silinecekkisi);
            db.SaveChanges();
            dataGridView1.DataSource = db.Öğrenci.ToList();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            MessageBox.Show("Öğrenci Kayıdı Silindi");
        }

        private void Ara_buton_Click(object sender, EventArgs e)
        {
            
        }

        private void Ara_txt_TextChanged(object sender, EventArgs e)
        {
            string aranan = Ara_txt.Text;
            var degerler = from item in db.Öğrenci
                           where item.Ad_Soyad.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler; (from x in db.Öğrenci
                                                  select new
                                                  {
                                                      x.ID,
                                                      x.Ad_Soyad,
                                                      x.Kayıt_Tarihi,
                                                      x.Öğrenci_No,
                                                      x.Doğum_Tarihi,
                                                      x.Bölüm

                                                  }).ToList();
        }
    }
}
