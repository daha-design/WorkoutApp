using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = @"Data Source=LAPTOP-M79G15GH\SQLEXPRESS;
                               Initial Catalog=aero;
                               Integrated Security=True;
                               TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 100 * FROM Trip", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}