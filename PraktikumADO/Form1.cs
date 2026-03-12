using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        // Deklarasi Variabel Koneksi & Command
        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Opsional: Set default text
            txtHasil.Text = "";
        }
        // Method untuk mengatur koneksi database
        private void Koneksi()
        {
            // PENTING: Sesuaikan "Data Source" dengan nama server SQL Server Anda
            conn = new SqlConnection(
                "Data Source=LAPTOP-4VAVDOFH\\WAWANLOMBOK;Initial Catalog=DBAkademikAD0;Integrated Security=True"
            );
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                MessageBox.Show("Koneksi ke database berhasil");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnHitungMhs_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "SELECT COUNT(*) FROM Mahasiswa";
                cmd = new SqlCommand(query, conn);

                // ExecuteScalar mengambil 1 nilai saja
                int jumlah = (int)cmd.ExecuteScalar();
                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnHitungMK_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "SELECT COUNT(*) FROM MataKuliah";
                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();
                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
