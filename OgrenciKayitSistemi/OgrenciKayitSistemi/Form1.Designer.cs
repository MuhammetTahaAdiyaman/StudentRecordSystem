namespace OgrenciKayitSistemi
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblOgrenciId = new System.Windows.Forms.Label();
            this.LblOgrenciAd = new System.Windows.Forms.Label();
            this.LblOgrenciSoyad = new System.Windows.Forms.Label();
            this.LblOgrenciNo = new System.Windows.Forms.Label();
            this.LblOgrenciDurum = new System.Windows.Forms.Label();
            this.TxtOgrenciId = new System.Windows.Forms.TextBox();
            this.TxtOgrenciAd = new System.Windows.Forms.TextBox();
            this.TxtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MskOgrenciNo = new System.Windows.Forms.MaskedTextBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnIstatistik = new System.Windows.Forms.Button();
            this.BtnGrafik = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciVeriTabaniDataSet = new OgrenciKayitSistemi.OgrenciVeriTabaniDataSet();
            this.tblOgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_OgrenciTableAdapter = new OgrenciKayitSistemi.OgrenciVeriTabaniDataSetTableAdapters.Tbl_OgrenciTableAdapter();
            this.ogrenciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MskOgrenciNo);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.TxtOgrenciSoyad);
            this.groupBox1.Controls.Add(this.TxtOgrenciAd);
            this.groupBox1.Controls.Add(this.TxtOgrenciId);
            this.groupBox1.Controls.Add(this.LblOgrenciDurum);
            this.groupBox1.Controls.Add(this.LblOgrenciNo);
            this.groupBox1.Controls.Add(this.LblOgrenciSoyad);
            this.groupBox1.Controls.Add(this.LblOgrenciAd);
            this.groupBox1.Controls.Add(this.LblOgrenciId);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(444, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogrenci Kayıt";
            // 
            // LblOgrenciId
            // 
            this.LblOgrenciId.AutoSize = true;
            this.LblOgrenciId.Location = new System.Drawing.Point(18, 97);
            this.LblOgrenciId.Name = "LblOgrenciId";
            this.LblOgrenciId.Size = new System.Drawing.Size(116, 28);
            this.LblOgrenciId.TabIndex = 0;
            this.LblOgrenciId.Text = "Ogrenci Id:";
            // 
            // LblOgrenciAd
            // 
            this.LblOgrenciAd.AutoSize = true;
            this.LblOgrenciAd.Location = new System.Drawing.Point(89, 225);
            this.LblOgrenciAd.Name = "LblOgrenciAd";
            this.LblOgrenciAd.Size = new System.Drawing.Size(45, 28);
            this.LblOgrenciAd.TabIndex = 1;
            this.LblOgrenciAd.Text = "Ad:";
            // 
            // LblOgrenciSoyad
            // 
            this.LblOgrenciSoyad.AutoSize = true;
            this.LblOgrenciSoyad.Location = new System.Drawing.Point(57, 293);
            this.LblOgrenciSoyad.Name = "LblOgrenciSoyad";
            this.LblOgrenciSoyad.Size = new System.Drawing.Size(77, 28);
            this.LblOgrenciSoyad.TabIndex = 2;
            this.LblOgrenciSoyad.Text = "Soyad:";
            // 
            // LblOgrenciNo
            // 
            this.LblOgrenciNo.AutoSize = true;
            this.LblOgrenciNo.Location = new System.Drawing.Point(8, 161);
            this.LblOgrenciNo.Name = "LblOgrenciNo";
            this.LblOgrenciNo.Size = new System.Drawing.Size(126, 28);
            this.LblOgrenciNo.TabIndex = 3;
            this.LblOgrenciNo.Text = "Ogrenci No:";
            // 
            // LblOgrenciDurum
            // 
            this.LblOgrenciDurum.AutoSize = true;
            this.LblOgrenciDurum.Location = new System.Drawing.Point(40, 357);
            this.LblOgrenciDurum.Name = "LblOgrenciDurum";
            this.LblOgrenciDurum.Size = new System.Drawing.Size(84, 28);
            this.LblOgrenciDurum.TabIndex = 4;
            this.LblOgrenciDurum.Text = "Durum:";
            // 
            // TxtOgrenciId
            // 
            this.TxtOgrenciId.Location = new System.Drawing.Point(140, 97);
            this.TxtOgrenciId.Name = "TxtOgrenciId";
            this.TxtOgrenciId.Size = new System.Drawing.Size(248, 36);
            this.TxtOgrenciId.TabIndex = 5;
            // 
            // TxtOgrenciAd
            // 
            this.TxtOgrenciAd.Location = new System.Drawing.Point(140, 222);
            this.TxtOgrenciAd.Name = "TxtOgrenciAd";
            this.TxtOgrenciAd.Size = new System.Drawing.Size(248, 36);
            this.TxtOgrenciAd.TabIndex = 7;
            // 
            // TxtOgrenciSoyad
            // 
            this.TxtOgrenciSoyad.Location = new System.Drawing.Point(140, 290);
            this.TxtOgrenciSoyad.Name = "TxtOgrenciSoyad";
            this.TxtOgrenciSoyad.Size = new System.Drawing.Size(248, 36);
            this.TxtOgrenciSoyad.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(140, 357);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 32);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Aktif";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(262, 357);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 32);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pasif";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGrafik);
            this.groupBox2.Controls.Add(this.BtnIstatistik);
            this.groupBox2.Controls.Add(this.BtnTemizle);
            this.groupBox2.Controls.Add(this.BtnGuncelle);
            this.groupBox2.Controls.Add(this.BtnSil);
            this.groupBox2.Controls.Add(this.BtnKaydet);
            this.groupBox2.Controls.Add(this.BtnListele);
            this.groupBox2.Location = new System.Drawing.Point(513, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(444, 459);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ogrenci Yonetim";
            // 
            // MskOgrenciNo
            // 
            this.MskOgrenciNo.Location = new System.Drawing.Point(140, 161);
            this.MskOgrenciNo.Mask = "000";
            this.MskOgrenciNo.Name = "MskOgrenciNo";
            this.MskOgrenciNo.Size = new System.Drawing.Size(248, 36);
            this.MskOgrenciNo.TabIndex = 11;
            this.MskOgrenciNo.ValidatingType = typeof(int);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(142, 39);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(175, 35);
            this.BtnListele.TabIndex = 0;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(142, 98);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(175, 35);
            this.BtnKaydet.TabIndex = 1;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(142, 162);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(175, 35);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(142, 224);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(175, 35);
            this.BtnGuncelle.TabIndex = 3;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(142, 282);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(175, 35);
            this.BtnTemizle.TabIndex = 4;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnIstatistik
            // 
            this.BtnIstatistik.Location = new System.Drawing.Point(142, 339);
            this.BtnIstatistik.Name = "BtnIstatistik";
            this.BtnIstatistik.Size = new System.Drawing.Size(175, 35);
            this.BtnIstatistik.TabIndex = 5;
            this.BtnIstatistik.Text = "İstatistik";
            this.BtnIstatistik.UseVisualStyleBackColor = true;
            this.BtnIstatistik.Click += new System.EventHandler(this.BtnIstatistik_Click);
            // 
            // BtnGrafik
            // 
            this.BtnGrafik.Location = new System.Drawing.Point(142, 395);
            this.BtnGrafik.Name = "BtnGrafik";
            this.BtnGrafik.Size = new System.Drawing.Size(175, 35);
            this.BtnGrafik.TabIndex = 6;
            this.BtnGrafik.Text = "Grafikler";
            this.BtnGrafik.UseVisualStyleBackColor = true;
            this.BtnGrafik.Click += new System.EventHandler(this.BtnGrafik_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(144, 481);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(686, 298);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIdDataGridViewTextBoxColumn,
            this.ogrenciNoDataGridViewTextBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn,
            this.ogrenciDurumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblOgrenciBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ogrenciVeriTabaniDataSet
            // 
            this.ogrenciVeriTabaniDataSet.DataSetName = "OgrenciVeriTabaniDataSet";
            this.ogrenciVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOgrenciBindingSource
            // 
            this.tblOgrenciBindingSource.DataMember = "Tbl_Ogrenci";
            this.tblOgrenciBindingSource.DataSource = this.ogrenciVeriTabaniDataSet;
            // 
            // tbl_OgrenciTableAdapter
            // 
            this.tbl_OgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciIdDataGridViewTextBoxColumn
            // 
            this.ogrenciIdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciId";
            this.ogrenciIdDataGridViewTextBoxColumn.HeaderText = "OgrenciId";
            this.ogrenciIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciIdDataGridViewTextBoxColumn.Name = "ogrenciIdDataGridViewTextBoxColumn";
            this.ogrenciIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrenciIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciNoDataGridViewTextBoxColumn
            // 
            this.ogrenciNoDataGridViewTextBoxColumn.DataPropertyName = "OgrenciNo";
            this.ogrenciNoDataGridViewTextBoxColumn.HeaderText = "OgrenciNo";
            this.ogrenciNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciNoDataGridViewTextBoxColumn.Name = "ogrenciNoDataGridViewTextBoxColumn";
            this.ogrenciNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciAdDataGridViewTextBoxColumn
            // 
            this.ogrenciAdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.HeaderText = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciAdDataGridViewTextBoxColumn.Name = "ogrenciAdDataGridViewTextBoxColumn";
            this.ogrenciAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.HeaderText = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciSoyadDataGridViewTextBoxColumn.Name = "ogrenciSoyadDataGridViewTextBoxColumn";
            this.ogrenciSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciDurumDataGridViewCheckBoxColumn
            // 
            this.ogrenciDurumDataGridViewCheckBoxColumn.DataPropertyName = "OgrenciDurum";
            this.ogrenciDurumDataGridViewCheckBoxColumn.HeaderText = "OgrenciDurum";
            this.ogrenciDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ogrenciDurumDataGridViewCheckBoxColumn.Name = "ogrenciDurumDataGridViewCheckBoxColumn";
            this.ogrenciDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Durum:";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(970, 783);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtOgrenciSoyad;
        private System.Windows.Forms.TextBox TxtOgrenciAd;
        private System.Windows.Forms.TextBox TxtOgrenciId;
        private System.Windows.Forms.Label LblOgrenciDurum;
        private System.Windows.Forms.Label LblOgrenciNo;
        private System.Windows.Forms.Label LblOgrenciSoyad;
        private System.Windows.Forms.Label LblOgrenciAd;
        private System.Windows.Forms.Label LblOgrenciId;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox MskOgrenciNo;
        private System.Windows.Forms.Button BtnGrafik;
        private System.Windows.Forms.Button BtnIstatistik;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OgrenciVeriTabaniDataSet ogrenciVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tblOgrenciBindingSource;
        private OgrenciVeriTabaniDataSetTableAdapters.Tbl_OgrenciTableAdapter tbl_OgrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ogrenciDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

