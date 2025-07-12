using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Asn1.Cms;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Withdraw : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4Q2ON6T4\\SQLEXPRESS01;Integrated Security=True");
        public Withdraw()
        {
            InitializeComponent();
        }
        int ID = 0;

        private void btn_withdraw_Click(object sender, EventArgs e)
        {

            con.Open();
            if (comboBox1.SelectedItem == "Withdraw")
            {
                SqlCommand cmd = new SqlCommand("update accounts set balance-= @amount WHERE account_number = @account_number", con);
                cmd.Parameters.AddWithValue("@account_number", txt_acc.Text);
                cmd.Parameters.AddWithValue("@amount", Convert.ToDouble(txt_amount.Text));
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update accounts set balance+= @amount WHERE account_number = @account_number", con);
                cmd.Parameters.AddWithValue("@account_number", txt_acc.Text);
                cmd.Parameters.AddWithValue("@amount", Convert.ToDouble(txt_amount.Text));
                cmd.ExecuteNonQuery();
            }
            SqlCommand cmd2 = new SqlCommand("insert into transactions values (@transaction_id,@account_number,@date,@amount,@transaction_type)", con);
            System.DateTime myDate = default(System.DateTime);
            myDate = dateTimePicker1.Value;
            cmd2.Parameters.AddWithValue("@transaction_id", txt_ID.Text);
            cmd2.Parameters.AddWithValue("@account_number", txt_acc.Text);
            cmd2.Parameters.AddWithValue("@date", myDate);
            cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(txt_amount.Text));
            cmd2.Parameters.AddWithValue("@transaction_type", comboBox1.SelectedItem);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Transaction Succesfull!");



            SqlCommand cmd3 = new SqlCommand("SELECT transaction_type FROM transactions", con);
            cmd3.Parameters.AddWithValue("@transaction_type", comboBox1.SelectedItem);
            cmd3 = new SqlCommand("SELECT balance FROM accounts WHERE account_number = @account_number", con);
            cmd3.Parameters.AddWithValue("@account_number", txt_acc.Text);
            SqlCommand cmd4 = new SqlCommand("SELECT email FROM accounts WHERE account_number = @account_number", con);
            cmd4.Parameters.AddWithValue("@account_number", txt_acc.Text);

            string email = (string)cmd4.ExecuteScalar();


            SqlDataReader reader1 = cmd3.ExecuteReader();

            if (MessageBox.Show("Do you want receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                reader1.Read();

                string userInput = "*******************************************\n" + "**             Transaction Receipt               **\n" + "*******************************************" + "\n" + "Date: " + myDate + "\n" + "Account number: " + txt_acc.Text + "\n" + "Amount: " + txt_amount.Text + "\n" + "Transaction ID: " + txt_ID.Text + "\n" + "Current Balance: " + "\n" + reader1.GetValue("balance").ToString().ToString();
                Document document = new Document();
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Receipt.pdf");
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();
                Paragraph p = new Paragraph(userInput);
                document.Add(p);
                document.Close();
                MessageBox.Show("Receipt Printed!");

                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("glasbanking@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Transaction from GlasBank";
                mail.Body = "Dear Valued Customer,\n" + " Thank you for using GLASBank you\n" + comboBox1.SelectedItem + txt_amount.Text + "if you did not make this transaction, call us at 12-200- 200\n" + " Sincerely, " + " GLAS bank & Trust Company - Consumer Business Sector\n" + "Note: This is system generated. Please do not reply through this email\n" + "Here's the Receipt for your transaction\n" + "*             Transaction Receipt               **\n" + "******************************************" + "\n" + "Date: " + myDate + "\n" + "Account number: " + txt_acc.Text + "\n" + "Amount: " + txt_amount.Text + "\n" + "Transaction ID: " + txt_ID.Text + "\n" + "Current Balance: " + "\n" + reader1.GetValue("balance").ToString();
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("glasbanking@gmail.com", "gkcphnzehaslxpaa");
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Email has been sent");

            }
            else
            {
                MessageBox.Show("Thank you for using GlasBank!");
                Application.Exit();
            }

            con.Close();
            displayData();
            Auto_Increment();

            txt_acc.Clear();
            txt_amount.Clear();


        }



        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

            Management m = new Management();
            m.Visible = true;
            this.Visible = false;
        }

        public void displayData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM transactions", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_acc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_amount.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            string[] role = { "Deposit", "Withdraw" };
            foreach (string roles in role)
            {
                comboBox1.Items.Add(roles);
            }
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now;
            displayData();
            Auto_Increment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Management m = new Management();
            m.Visible = true;
            this.Visible = false;
        }
        private void Auto_Increment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(transaction_id) from [transactions]", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            txt_ID.Text = ID + i.ToString();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * FROM customers WHERE account_number = @account_number", con);
            cmd.Parameters.AddWithValue("@account_number", int.Parse(txt_search.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            txt_search.Clear();

        }


    }
}
