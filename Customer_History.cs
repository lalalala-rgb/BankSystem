using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Customer_History : Form
    {
        private string username;
        public Customer_History(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4Q2ON6T4\\SQLEXPRESS01;Integrated Security=True");

        private void Customer_History_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select username FROM accounts WHERE username = @username", con);
            cmd.Parameters.AddWithValue("@username", username);

            cmd.ExecuteNonQuery();
            con.Close();
            displayData();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            User_Dashboard u = new User_Dashboard(username);
            u.Visible = true;
            this.Visible = false;
        }
        public void displayData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT account_number FROM accounts WHERE username = @username", con);
            cmd.Parameters.AddWithValue("@username", username);
            string acc = (string)cmd.ExecuteScalar();
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM transactions WHERE account_number = @account_number", con);
            sda.SelectCommand.Parameters.AddWithValue("@account_number", acc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn_payBills_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT account_number FROM accounts WHERE username = @username", con);
            cmd.Parameters.AddWithValue("@username", username);
            string acc = (string)cmd.ExecuteScalar();
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM  payBill WHERE account_number = @account_number", con);
            sda.SelectCommand.Parameters.AddWithValue("@account_number", acc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
