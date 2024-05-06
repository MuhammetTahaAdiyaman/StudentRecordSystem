namespace OgrenciKayitSistemi
{
    partial class FrmIstatistik
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
            this.LblToplamOgrenci = new System.Windows.Forms.Label();
            this.LblAktifOgrenci = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblPasifOgrenci = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblToplamOgrenci
            // 
            this.LblToplamOgrenci.AutoSize = true;
            this.LblToplamOgrenci.Location = new System.Drawing.Point(86, 109);
            this.LblToplamOgrenci.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblToplamOgrenci.Name = "LblToplamOgrenci";
            this.LblToplamOgrenci.Size = new System.Drawing.Size(226, 28);
            this.LblToplamOgrenci.TabIndex = 0;
            this.LblToplamOgrenci.Text = "Toplam Öğrenci Sayısı:";
            // 
            // LblAktifOgrenci
            // 
            this.LblAktifOgrenci.AutoSize = true;
            this.LblAktifOgrenci.Location = new System.Drawing.Point(85, 189);
            this.LblAktifOgrenci.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAktifOgrenci.Name = "LblAktifOgrenci";
            this.LblAktifOgrenci.Size = new System.Drawing.Size(201, 28);
            this.LblAktifOgrenci.TabIndex = 1;
            this.LblAktifOgrenci.Text = "Aktif Öğrenci Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "0";
            // 
            // LblPasifOgrenci
            // 
            this.LblPasifOgrenci.AutoSize = true;
            this.LblPasifOgrenci.Location = new System.Drawing.Point(86, 271);
            this.LblPasifOgrenci.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPasifOgrenci.Name = "LblPasifOgrenci";
            this.LblPasifOgrenci.Size = new System.Drawing.Size(200, 28);
            this.LblPasifOgrenci.TabIndex = 4;
            this.LblPasifOgrenci.Text = "Pasif Öğrenci Sayısı:";
            // 
            // FrmIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 427);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblPasifOgrenci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblAktifOgrenci);
            this.Controls.Add(this.LblToplamOgrenci);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmIstatistik";
            this.Text = "FrmIstatistik";
            this.Load += new System.EventHandler(this.FrmIstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblToplamOgrenci;
        private System.Windows.Forms.Label LblAktifOgrenci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblPasifOgrenci;
    }
}