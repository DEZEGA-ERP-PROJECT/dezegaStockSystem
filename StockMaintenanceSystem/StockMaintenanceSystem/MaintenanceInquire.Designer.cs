﻿
namespace StockMaintenanceSystem
{
    partial class MaintenanceInquire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceInquire));
            this.btn2SorgulaAnasayfayaDon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn2SorgulaTemizle = new System.Windows.Forms.Button();
            this.btn2SorgulaSorgula = new System.Windows.Forms.Button();
            this.lbl2SorgulaEkipmanAdi = new System.Windows.Forms.Label();
            this.lblBakimBaslangicTarihSorgula = new System.Windows.Forms.Label();
            this.dateTimeBaslangicSorgula = new System.Windows.Forms.DateTimePicker();
            this.SorgulaEkipmanAdi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2SorgulaAnasayfayaDon
            // 
            this.btn2SorgulaAnasayfayaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2SorgulaAnasayfayaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn2SorgulaAnasayfayaDon.Image")));
            this.btn2SorgulaAnasayfayaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2SorgulaAnasayfayaDon.Location = new System.Drawing.Point(1182, 93);
            this.btn2SorgulaAnasayfayaDon.Name = "btn2SorgulaAnasayfayaDon";
            this.btn2SorgulaAnasayfayaDon.Size = new System.Drawing.Size(78, 41);
            this.btn2SorgulaAnasayfayaDon.TabIndex = 56;
            this.btn2SorgulaAnasayfayaDon.Text = "GERİ";
            this.btn2SorgulaAnasayfayaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2SorgulaAnasayfayaDon.UseVisualStyleBackColor = true;
            this.btn2SorgulaAnasayfayaDon.Click += new System.EventHandler(this.btn2SorgulaAnasayfayadon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(985, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 142);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1245, 490);
            this.dataGridView2.TabIndex = 54;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btn2SorgulaTemizle
            // 
            this.btn2SorgulaTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2SorgulaTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2SorgulaTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btn2SorgulaTemizle.Image")));
            this.btn2SorgulaTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2SorgulaTemizle.Location = new System.Drawing.Point(714, 76);
            this.btn2SorgulaTemizle.Name = "btn2SorgulaTemizle";
            this.btn2SorgulaTemizle.Size = new System.Drawing.Size(120, 48);
            this.btn2SorgulaTemizle.TabIndex = 53;
            this.btn2SorgulaTemizle.Text = "Temizle";
            this.btn2SorgulaTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2SorgulaTemizle.UseVisualStyleBackColor = true;
            this.btn2SorgulaTemizle.Click += new System.EventHandler(this.btn2SorgulaTemizle_Click);
            // 
            // btn2SorgulaSorgula
            // 
            this.btn2SorgulaSorgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2SorgulaSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2SorgulaSorgula.Image = ((System.Drawing.Image)(resources.GetObject("btn2SorgulaSorgula.Image")));
            this.btn2SorgulaSorgula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2SorgulaSorgula.Location = new System.Drawing.Point(714, 22);
            this.btn2SorgulaSorgula.Name = "btn2SorgulaSorgula";
            this.btn2SorgulaSorgula.Size = new System.Drawing.Size(120, 49);
            this.btn2SorgulaSorgula.TabIndex = 51;
            this.btn2SorgulaSorgula.Text = "Sorgula";
            this.btn2SorgulaSorgula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2SorgulaSorgula.UseVisualStyleBackColor = true;
            this.btn2SorgulaSorgula.Click += new System.EventHandler(this.btn2SorgulaSorgula_Click);
            // 
            // lbl2SorgulaEkipmanAdi
            // 
            this.lbl2SorgulaEkipmanAdi.AutoSize = true;
            this.lbl2SorgulaEkipmanAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2SorgulaEkipmanAdi.Location = new System.Drawing.Point(250, 93);
            this.lbl2SorgulaEkipmanAdi.Name = "lbl2SorgulaEkipmanAdi";
            this.lbl2SorgulaEkipmanAdi.Size = new System.Drawing.Size(110, 18);
            this.lbl2SorgulaEkipmanAdi.TabIndex = 48;
            this.lbl2SorgulaEkipmanAdi.Text = "Ekipman Adıı:";
            // 
            // lblBakimBaslangicTarihSorgula
            // 
            this.lblBakimBaslangicTarihSorgula.AutoSize = true;
            this.lblBakimBaslangicTarihSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBakimBaslangicTarihSorgula.Location = new System.Drawing.Point(238, 37);
            this.lblBakimBaslangicTarihSorgula.Name = "lblBakimBaslangicTarihSorgula";
            this.lblBakimBaslangicTarihSorgula.Size = new System.Drawing.Size(133, 18);
            this.lblBakimBaslangicTarihSorgula.TabIndex = 58;
            this.lblBakimBaslangicTarihSorgula.Text = "Başlangıç Tarihi:";
            // 
            // dateTimeBaslangicSorgula
            // 
            this.dateTimeBaslangicSorgula.Location = new System.Drawing.Point(393, 34);
            this.dateTimeBaslangicSorgula.Name = "dateTimeBaslangicSorgula";
            this.dateTimeBaslangicSorgula.Size = new System.Drawing.Size(200, 20);
            this.dateTimeBaslangicSorgula.TabIndex = 59;
            this.dateTimeBaslangicSorgula.ValueChanged += new System.EventHandler(this.dateTimeBaslangicSorgula_ValueChanged);
            // 
            // SorgulaEkipmanAdi
            // 
            this.SorgulaEkipmanAdi.FormattingEnabled = true;
            this.SorgulaEkipmanAdi.Location = new System.Drawing.Point(393, 90);
            this.SorgulaEkipmanAdi.Name = "SorgulaEkipmanAdi";
            this.SorgulaEkipmanAdi.Size = new System.Drawing.Size(200, 21);
            this.SorgulaEkipmanAdi.TabIndex = 60;
            // 
            // MaintenanceInquire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1275, 647);
            this.Controls.Add(this.SorgulaEkipmanAdi);
            this.Controls.Add(this.dateTimeBaslangicSorgula);
            this.Controls.Add(this.lblBakimBaslangicTarihSorgula);
            this.Controls.Add(this.btn2SorgulaAnasayfayaDon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn2SorgulaTemizle);
            this.Controls.Add(this.btn2SorgulaSorgula);
            this.Controls.Add(this.lbl2SorgulaEkipmanAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MaintenanceInquire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakım Onarım Sorgulama Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaintenanceInquire_FormClosing);
            this.Load += new System.EventHandler(this.MaintenanceInquire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2SorgulaAnasayfayaDon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn2SorgulaTemizle;
        private System.Windows.Forms.Button btn2SorgulaSorgula;
        private System.Windows.Forms.Label lbl2SorgulaEkipmanAdi;
        private System.Windows.Forms.Label lblBakimBaslangicTarihSorgula;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangicSorgula;
        private System.Windows.Forms.ComboBox SorgulaEkipmanAdi;
    }
}