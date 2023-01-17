namespace Görsel_Vize
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.Ogrenci_buton = new System.Windows.Forms.Button();
            this.ODers_buton = new System.Windows.Forms.Button();
            this.OYonetim_buton = new System.Windows.Forms.Button();
            this.YDers_buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(98, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(795, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "OKUL İDARE SİSTEMİNE HOŞ GELDİNİZ\r\n";
            // 
            // Ogrenci_buton
            // 
            this.Ogrenci_buton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ogrenci_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Ogrenci_buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ogrenci_buton.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ogrenci_buton.Location = new System.Drawing.Point(18, 325);
            this.Ogrenci_buton.Name = "Ogrenci_buton";
            this.Ogrenci_buton.Size = new System.Drawing.Size(200, 100);
            this.Ogrenci_buton.TabIndex = 1;
            this.Ogrenci_buton.Text = "Öğrenci";
            this.Ogrenci_buton.UseVisualStyleBackColor = false;
            this.Ogrenci_buton.Click += new System.EventHandler(this.Ogrenci_buton_Click);
            // 
            // ODers_buton
            // 
            this.ODers_buton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ODers_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ODers_buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ODers_buton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ODers_buton.Location = new System.Drawing.Point(271, 325);
            this.ODers_buton.Name = "ODers_buton";
            this.ODers_buton.Size = new System.Drawing.Size(200, 100);
            this.ODers_buton.TabIndex = 2;
            this.ODers_buton.Text = "Öğrenci Ders";
            this.ODers_buton.UseVisualStyleBackColor = false;
            this.ODers_buton.Click += new System.EventHandler(this.ODers_buton_Click);
            // 
            // OYonetim_buton
            // 
            this.OYonetim_buton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OYonetim_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.OYonetim_buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OYonetim_buton.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OYonetim_buton.Location = new System.Drawing.Point(522, 325);
            this.OYonetim_buton.Name = "OYonetim_buton";
            this.OYonetim_buton.Size = new System.Drawing.Size(200, 100);
            this.OYonetim_buton.TabIndex = 3;
            this.OYonetim_buton.Text = "Okul Yönetimi";
            this.OYonetim_buton.UseVisualStyleBackColor = false;
            this.OYonetim_buton.Click += new System.EventHandler(this.OYonetim_buton_Click);
            // 
            // YDers_buton
            // 
            this.YDers_buton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YDers_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.YDers_buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YDers_buton.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YDers_buton.ForeColor = System.Drawing.Color.Black;
            this.YDers_buton.Location = new System.Drawing.Point(766, 325);
            this.YDers_buton.Name = "YDers_buton";
            this.YDers_buton.Size = new System.Drawing.Size(200, 100);
            this.YDers_buton.TabIndex = 4;
            this.YDers_buton.Text = "Yönetim Ders";
            this.YDers_buton.UseVisualStyleBackColor = false;
            this.YDers_buton.Click += new System.EventHandler(this.YDers_buton_Click);
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Görsel_Vize.Properties.Resources._1_pru77_3338b_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.YDers_buton);
            this.Controls.Add(this.OYonetim_buton);
            this.Controls.Add(this.ODers_buton);
            this.Controls.Add(this.Ogrenci_buton);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ÖğrenciDers_buton;
        private System.Windows.Forms.Button Öğrenci_buton;
        private System.Windows.Forms.Button OkulYönetim_buton;
        private System.Windows.Forms.Button Ders_buton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ogrenci_buton;
        private System.Windows.Forms.Button ODers_buton;
        private System.Windows.Forms.Button OYonetim_buton;
        private System.Windows.Forms.Button YDers_buton;
    }
}

