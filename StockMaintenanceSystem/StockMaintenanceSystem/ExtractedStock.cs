﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StockMaintenanceSystem
{
    public partial class ExtractedStock : Form
    {
        public ExtractedStock()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-FMSK50S; Initial Catalog = dbStock; Integrated Security = True");
        private void btnCikanYeni_Click(object sender, EventArgs e)
        {
            // Button Çıkan Yeni
            StockSystem ss = new StockSystem();
            ss.Show();
            this.Hide();
        }

        private void btnCikanCikan_Click(object sender, EventArgs e)
        {
            // Button Çıkan Çıkan
            /*
            AddedStock added = new AddedStock();
            added.Show();
            this.Hide(); */
        }

        private void btnCikanSorgula_Click(object sender, EventArgs e)
        {
            // Çıkan Sorgula
            Inquire inq = new Inquire();
            inq.Show();
            this.Hide();
        }

        private void btnCikanAnasayfa_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }

        private void btnCikanGelen_Click(object sender, EventArgs e)
        {
            // Button Çıkan Gelen
            AddedStock added = new AddedStock();
            added.Show();
            this.Hide();
            // test test
        }

        private void btnCikanKaydet_Click(object sender, EventArgs e)
        {

            if (cmbCikan.Text == " " || txtCikanKod.Text == " " || cmbCikanAdi.Text == " " || txtCikanMarkasi.Text == " " || txtCikanModel.Text == " " || dTimeCikanTarih.Text == " " || txtCikanSerino.Text == " " || txtCikanAdet.Text == " " || txtCikanAmacNeden.Text == " " ||
                cmbCikan.Text == String.Empty || txtCikanKod.Text == String.Empty || cmbCikanAdi.Text == String.Empty || txtCikanMarkasi.Text == String.Empty || txtCikanModel.Text == String.Empty || dTimeCikanTarih.Text == String.Empty || txtCikanSerino.Text == String.Empty || txtCikanAdet.Text == String.Empty || txtCikanAmacNeden.Text == String.Empty)
            {
                MessageBox.Show("Lütfen (*) Alan Bilgilerini Doldurunuz!!");
            }
            else
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Update tblEquipmentStock set EquipmentStockNumber = EquipmentStockNumber-'" +
                                              int.Parse(txtCikanAdet.Text) + "'where EquipmentCode='" + txtCikanKod.Text + "' ", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Çıkan EKipman Kaydetme İşlemi Başarılı!!");
            }           

        }

        private void BtnCikanTemizle_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblCategory";
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbCikan.Items.Add(dr["CategoryName"]);
            }
            conn.Close();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT *FROM tblEquipmentStock";
            command.Connection = conn;
            command.CommandType = CommandType.Text;

            SqlDataReader dataReader;
            conn.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbCikanAdi.Items.Add(dataReader["EquipmentName"]);
            }
            conn.Close();

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblEquipmentStock WHERE EquipmentName like'" + cmbCikanAdi.Text + "'", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {

                txtCikanKod.Text = read["EquipmentCode"].ToString();
                txtCikanMarkasi.Text = read["EquipmentBrand"].ToString();
                txtCikanModel.Text = read["EquipmentModel"].ToString();
                txtCikanSerino.Text = read["EquipmentSerialNumber"].ToString();


            }
            conn.Close();
        }

        private void ExtractedStock_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblCategory";
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbCikan.Items.Add(dr["CategoryName"]);
            }
            conn.Close();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT *FROM tblEquipmentStock";
            command.Connection = conn;
            command.CommandType = CommandType.Text;

            SqlDataReader dataReader;
            conn.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbCikanAdi.Items.Add(dataReader["EquipmentName"]);
            }
            conn.Close();
        }

        private void txtCikanSerino_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockList list = new StockList();
            list.Show();
            this.Hide();
        }

        private void cmbCikanAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblEquipmentStock WHERE EquipmentName like'" + cmbCikanAdi.Text + "'", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {

                txtCikanKod.Text = read["EquipmentCode"].ToString();
                txtCikanMarkasi.Text = read["EquipmentBrand"].ToString();
                txtCikanModel.Text = read["EquipmentModel"].ToString();
                txtCikanSerino.Text = read["EquipmentSerialNumber"].ToString();


            }
            conn.Close();
        }

        private void ExtractedStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış Yapılıyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Application.ExitThread();

        }
    }
}
