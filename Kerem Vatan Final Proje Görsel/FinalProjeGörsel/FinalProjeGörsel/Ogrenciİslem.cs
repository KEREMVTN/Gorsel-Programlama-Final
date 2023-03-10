using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjeGörsel
{
    public partial class Ogrenciİslem : Form
    {
        public Ogrenciİslem()
        {
            InitializeComponent();
        }

        FinalEntities db= new FinalEntities();
        private void Ogrenciİslem_Load(object sender, EventArgs e)
        {
            
        }
        

        private void Ekle_buton_Click(object sender, EventArgs e)
        {
            Ogrenci öğrenci = new Ogrenci();
            öğrenci.Ad_Soyad = adSoyadtxt.Text;
            öğrenci.Kayıt_Tarihi = kytTrh.Value;
            öğrenci.Öğrenci_No = nmrtxt.Text;
            öğrenci.Doğum_Tarihi = Dgmtrh.Value;
            öğrenci.Bölümü = BlmTxt.Text;
            db.Ogrenci.Add(öğrenci);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Eklendi");
        }

        private void Güncelle_buton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var öğrenci = db.Ogrenci.Find(x);
            öğrenci.Ad_Soyad = adSoyadtxt.Text;
            öğrenci.Kayıt_Tarihi = kytTrh.Value;
            öğrenci.Öğrenci_No = nmrtxt.Text;
            öğrenci.Doğum_Tarihi = Dgmtrh.Value;
            öğrenci.Bölümü = BlmTxt.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Güncellendi");
        }

        private void Sil_buton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var öğrenci = db.Ogrenci.Find(x);
            db.Ogrenci.Remove(öğrenci);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Silindi");
        }
    }
}
