namespace Görsel_Vize
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Güncelle_buton = new System.Windows.Forms.Button();
            this.Ekle_buton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Ara_txt = new System.Windows.Forms.TextBox();
            this.Sil_buton = new System.Windows.Forms.Button();
            this.yönetimDersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.görsel_Programlama_VizeDataSet = new Görsel_Vize.Görsel_Programlama_VizeDataSet();
            this.öğrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.yönetimDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yönetimDersTableAdapter = new Görsel_Vize.Görsel_Programlama_VizeDataSetTableAdapters.YönetimDersTableAdapter();
            this.öğrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.öğrenciTableAdapter = new Görsel_Vize.Görsel_Programlama_VizeDataSetTableAdapters.ÖğrenciTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fKÖDersYönetimDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.öDersTableAdapter = new Görsel_Vize.Görsel_Programlama_VizeDataSetTableAdapters.ÖDersTableAdapter();
            this.fKÖDersYönetimDersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yönetimDersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.öğrenciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.yönetimDersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fKÖDersÖğrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.öDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yönetimDersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.öğrenciBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yönetimDersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.görsel_Programlama_VizeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yönetimDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKÖDersYönetimDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKÖDersYönetimDersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yönetimDersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yönetimDersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKÖDersÖğrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.öDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yönetimDersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBindingSource3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(981, 345);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Güncelle_buton
            // 
            this.Güncelle_buton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Güncelle_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Güncelle_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Güncelle_buton.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Güncelle_buton.Location = new System.Drawing.Point(433, 54);
            this.Güncelle_buton.Name = "Güncelle_buton";
            this.Güncelle_buton.Size = new System.Drawing.Size(150, 36);
            this.Güncelle_buton.TabIndex = 47;
            this.Güncelle_buton.Text = "Güncelle";
            this.Güncelle_buton.UseVisualStyleBackColor = false;
            this.Güncelle_buton.Click += new System.EventHandler(this.Güncelle_buton_Click);
            // 
            // Ekle_buton
            // 
            this.Ekle_buton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ekle_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Ekle_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekle_buton.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekle_buton.Location = new System.Drawing.Point(433, 12);
            this.Ekle_buton.Name = "Ekle_buton";
            this.Ekle_buton.Size = new System.Drawing.Size(150, 36);
            this.Ekle_buton.TabIndex = 45;
            this.Ekle_buton.Text = "Ekle";
            this.Ekle_buton.UseVisualStyleBackColor = false;
            this.Ekle_buton.Click += new System.EventHandler(this.Ekle_buton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 36);
            this.label3.TabIndex = 43;
            this.label3.Text = "Öğrenci ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 36);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ders ID";
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID.Location = new System.Drawing.Point(12, 12);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(169, 36);
            this.ID.TabIndex = 41;
            this.ID.Text = "ID";
            // 
            // Ara_txt
            // 
            this.Ara_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ara_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ara_txt.Location = new System.Drawing.Point(7, 36);
            this.Ara_txt.Multiline = true;
            this.Ara_txt.Name = "Ara_txt";
            this.Ara_txt.Size = new System.Drawing.Size(240, 36);
            this.Ara_txt.TabIndex = 40;
            this.Ara_txt.TextChanged += new System.EventHandler(this.Ara_txt_TextChanged);
            // 
            // Sil_buton
            // 
            this.Sil_buton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sil_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Sil_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sil_buton.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil_buton.Location = new System.Drawing.Point(433, 96);
            this.Sil_buton.Name = "Sil_buton";
            this.Sil_buton.Size = new System.Drawing.Size(150, 36);
            this.Sil_buton.TabIndex = 46;
            this.Sil_buton.Text = "Sil";
            this.Sil_buton.UseVisualStyleBackColor = false;
            this.Sil_buton.Click += new System.EventHandler(this.Sil_buton_Click);
            // 
            // yönetimDersBindingSource1
            // 
            this.yönetimDersBindingSource1.DataMember = "YönetimDers";
            this.yönetimDersBindingSource1.DataSource = this.görsel_Programlama_VizeDataSet;
            // 
            // görsel_Programlama_VizeDataSet
            // 
            this.görsel_Programlama_VizeDataSet.DataSetName = "Görsel_Programlama_VizeDataSet";
            this.görsel_Programlama_VizeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // öğrenciBindingSource1
            // 
            this.öğrenciBindingSource1.DataMember = "Öğrenci";
            this.öğrenciBindingSource1.DataSource = this.görsel_Programlama_VizeDataSet;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(-1, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1024, 10);
            this.label1.TabIndex = 53;
            this.label1.Text = "sadjhsadjsahaskd";
            // 
            // yönetimDersBindingSource
            // 
            this.yönetimDersBindingSource.DataMember = "YönetimDers";
            this.yönetimDersBindingSource.DataSource = this.görsel_Programlama_VizeDataSet;
            // 
            // yönetimDersTableAdapter
            // 
            this.yönetimDersTableAdapter.ClearBeforeFill = true;
            // 
            // öğrenciBindingSource
            // 
            this.öğrenciBindingSource.DataMember = "Öğrenci";
            this.öğrenciBindingSource.DataSource = this.görsel_Programlama_VizeDataSet;
            // 
            // öğrenciTableAdapter
            // 
            this.öğrenciTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(187, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 36);
            this.textBox1.TabIndex = 54;
            // 
            // fKÖDersYönetimDersBindingSource
            // 
            this.fKÖDersYönetimDersBindingSource.DataMember = "FK_ÖDers_YönetimDers";
            this.fKÖDersYönetimDersBindingSource.DataSource = this.yönetimDersBindingSource;
            // 
            // öDersTableAdapter
            // 
            this.öDersTableAdapter.ClearBeforeFill = true;
            // 
            // fKÖDersYönetimDersBindingSource1
            // 
            this.fKÖDersYönetimDersBindingSource1.DataMember = "FK_ÖDers_YönetimDers";
            this.fKÖDersYönetimDersBindingSource1.DataSource = this.yönetimDersBindingSource1;
            // 
            // yönetimDersBindingSource2
            // 
            this.yönetimDersBindingSource2.DataMember = "YönetimDers";
            this.yönetimDersBindingSource2.DataSource = this.görsel_Programlama_VizeDataSet;
            // 
            // öğrenciBindingSource2
            // 
            this.öğrenciBindingSource2.DataMember = "Öğrenci";
            this.öğrenciBindingSource2.DataSource = this.görsel_Programlama_VizeDataSet;
            // 
            // yönetimDersBindingSource3
            // 
            this.yönetimDersBindingSource3.DataMember = "YönetimDers";
            this.yönetimDersBindingSource3.DataSource = this.görsel_Programlama_VizeDataSet;
            // 
            // fKÖDersÖğrenciBindingSource
            // 
            this.fKÖDersÖğrenciBindingSource.DataMember = "FK_ÖDers_Öğrenci";
            this.fKÖDersÖğrenciBindingSource.DataSource = this.öğrenciBindingSource2;
            // 
            // öDersBindingSource
            // 
            this.öDersBindingSource.DataMember = "ÖDers";
            this.öDersBindingSource.DataSource = this.görsel_Programlama_VizeDataSet;
            // 
            // yönetimDersBindingSource4
            // 
            this.yönetimDersBindingSource4.DataMember = "YönetimDers";
            this.yönetimDersBindingSource4.DataSource = this.görsel_Programlama_VizeDataSet;
            // 
            // öğrenciBindingSource3
            // 
            this.öğrenciBindingSource3.DataMember = "Öğrenci";
            this.öğrenciBindingSource3.DataSource = this.görsel_Programlama_VizeDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ara_txt);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(743, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 78);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Ara";
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 30;
            this.comboBox1.Location = new System.Drawing.Point(187, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 36);
            this.comboBox1.TabIndex = 56;
            // 
            // comboBox2
            // 
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 30;
            this.comboBox2.Location = new System.Drawing.Point(187, 96);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(240, 36);
            this.comboBox2.TabIndex = 57;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Güncelle_buton);
            this.Controls.Add(this.Sil_buton);
            this.Controls.Add(this.Ekle_buton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ders";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yönetimDersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.görsel_Programlama_VizeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yönetimDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKÖDersYönetimDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKÖDersYönetimDersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yönetimDersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yönetimDersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKÖDersÖğrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.öDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yönetimDersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.öğrenciBindingSource3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Güncelle_buton;
        private System.Windows.Forms.Button Ekle_buton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox Ara_txt;
        private System.Windows.Forms.Button Sil_buton;
        private System.Windows.Forms.Label label1;
        private Görsel_Programlama_VizeDataSet görsel_Programlama_VizeDataSet;
        private System.Windows.Forms.BindingSource yönetimDersBindingSource;
        private Görsel_Programlama_VizeDataSetTableAdapters.YönetimDersTableAdapter yönetimDersTableAdapter;
        private System.Windows.Forms.BindingSource öğrenciBindingSource;
        private Görsel_Programlama_VizeDataSetTableAdapters.ÖğrenciTableAdapter öğrenciTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource fKÖDersYönetimDersBindingSource;
        private Görsel_Programlama_VizeDataSetTableAdapters.ÖDersTableAdapter öDersTableAdapter;
        private System.Windows.Forms.BindingSource yönetimDersBindingSource1;
        private System.Windows.Forms.BindingSource fKÖDersYönetimDersBindingSource1;
        private System.Windows.Forms.BindingSource öğrenciBindingSource1;
        private System.Windows.Forms.BindingSource yönetimDersBindingSource2;
        private System.Windows.Forms.BindingSource öğrenciBindingSource2;
        private System.Windows.Forms.BindingSource yönetimDersBindingSource3;
        private System.Windows.Forms.BindingSource fKÖDersÖğrenciBindingSource;
        private System.Windows.Forms.BindingSource öğrenciBindingSource3;
        private System.Windows.Forms.BindingSource yönetimDersBindingSource4;
        private System.Windows.Forms.BindingSource öDersBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}