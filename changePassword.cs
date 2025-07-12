using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class changePass : Form
    {
        public changePass()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4Q2ON6T4\\SQLEXPRESS01;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtnewPass.Text == txtconfirmPass.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE employee SET password = @password WHERE username = @username", con);

                cmd.Parameters.AddWithValue("@username", txtID.Text);
                cmd.Parameters.AddWithValue("@password", txtconfirmPass.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Successfully Updated!");
                Login_Form l = new Login_Form();
                l.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_Form l = new Login_Form();
            l.Visible = true;
            this.Visible = false;
        }

        private void changePass_Load(object sender, EventArgs e)
        {

        }
    }
}

