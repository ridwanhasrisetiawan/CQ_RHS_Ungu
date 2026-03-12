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