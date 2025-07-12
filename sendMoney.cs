using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace BankSystem
{
    public partial class sendMoney : Form
    {
        private string username;
        public sendMoney(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4Q2ON6T4\\SQLEXPRESS01;Integrated Security=True");


        int ID = 0;
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            con.Open();
            System.DateTime myDate = default(System.DateTime);
            myDate = dateTimePicker1.Value;
            SqlCommand cmd = new SqlCommand("UPDATE accounts SET balance+= @amount WHERE account_number = @account_number", con);
            cmd.Parameters.AddWithValue("@account_number", txt_toAcc.Text);
            cmd.Parameters.AddWithValue("@amount", Convert.ToDouble(txt_amount.Text));
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("UPDATE accounts SET balance -= @amount WHERE account_number = @account_number", con);
            cmd.Parameters.AddWithValue("@account_number", txt_fromAcc.Text);
            cmd.Parameters.AddWithValue("@amount", Convert.ToDouble(txt_amount.Text));
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("INSERT INTO transfer_Money values (@transaction_id,@account_number,@toAccount_number,@date,@amount,@transaction_type)", con);
            cmd.Parameters.AddWithValue("@transaction_id", txt_ID.Text);
            cmd.Parameters.AddWithValue("@account_number", txt_fromAcc.Text);
            cmd.Parameters.AddWithValue("@toAccount_number", txt_toAcc.Text);
            cmd.Parameters.AddWithValue("@date", myDate);
            cmd.Parameters.AddWithValue("@amount", Convert.ToDouble(txt_amount.Text));
            cmd.Parameters.AddWithValue("@transaction_type", "Transfer Money");
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("SELECT balance FROM accounts WHERE username = @username", con);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader reader1 = cmd.ExecuteReader();
            reader1.Read();

            string userInput = "*******************************************\n" + "**             Transaction Receipt               **\n" + "*******************************************" + "\n" + "Date: " + myDate + "\n" + "Account number: " + txt_fromAcc.Text + "\n" + "Amount: " + txt_amount.Text + "\n" + "Transaction ID: " + txt_ID.Text + "\n" + "Current Balance: " + "\n" + reader1.GetValue("balance").ToString().ToString();
            Document document = new Document();
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Receipt.pdf");
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();
            Paragraph p = new Paragraph(userInput);
            document.Add(p);
            document.Close();
            MessageBox.Show("Receipt Printed!");
            cmd = new SqlCommand("SELECT email FROM accounts WHERE account_number = @account_number", con);
            cmd.Parameters.AddWithValue("@account_number", txt_fromAcc.Text);
            string email = (string)cmd.ExecuteScalar();

            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("glasbanking@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Transaction from GlasBank";
            mail.Body = "Dear Valued Customer,\n" + " Thank you for using GLASBank you transfered money with the amount of \n" + txt_amount.Text + "to" + txt_toAcc + "if you did not make this transaction, call us at 12-200-200\n" + " Sincerely, " + " GLAS bank & Trust Company - Consumer Business Sector\n" + "Note: This is system generated. Please do not reply through this email\n" + "Here's the Receipt for your transaction\n" + "*             Transaction Receipt               **\n" + "******************************************" + "\n" + "Date: " + myDate + "\n" + "Account number: " + txt_fromAcc.Text + "\n" + "Amount: " + txt_amount.Text + "\n" + "Transaction ID: " + txt_ID.Text + "\n" + "Current Balance: " + "\n" + reader1.GetValue("balance").ToString();
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("glasbanking@gmail.com", "gkcphnzehaslxpaa");
            smtp.EnableSsl = true;
            smtp.Send(mail);

            MessageBox.Show("Email has been sent");


            reader1.Close();
            con.Close();
            MessageBox.Show("Transaction Succesfull!");
            txt_amount.Clear();
            txt_fromAcc.Clear();
            txt_toAcc.Clear();

            Auto_Increment();


        }

        private void sendMoney_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now;
            con.Open();
            SqlCommand cmd = new SqlCommand("select username FROM accounts WHERE username = @username", con);
            cmd.Parameters.AddWithValue("@username", username);

            con.Close();
            Auto_Increment();

        }
        private void Auto_Increment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(transaction_id) from [transfer_Money]", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            txt_ID.Text = ID + i.ToString();
        }

        private void btn_Backk_Click(object sender, EventArgs e)
        {
            User_Dashboard c = new User_Dashboard(username);
            c.Visible = true;
            this.Visible = false;
        }
    }
}
