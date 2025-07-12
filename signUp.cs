using System.Net.Mail;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Text;
using System.Net;
using System.Drawing;
using static System.Net.WebRequestMethods;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4Q2ON6T4\\SQLEXPRESS01;Integrated Security=True");

        private string otp;
        private int currentTimerValue = 60;
        private string GenerateOTP()
        {
            int length = 6;
            const string chars = "1234567890";

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] data = new byte[length];
                rng.GetBytes(data);

                StringBuilder result = new StringBuilder(length);
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length)]);
                }

                return result.ToString();
            }
        }
        private void SendOTP(string email, string otp)
        {


            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("glasbanking@gmail.com");
            mail.To.Add(email);
            mail.Subject = "OTP Verification";
            mail.Body = "Your OTP: " + otp;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("glasbanking@gmail.com", "gkcphnzehaslxpaa");
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string OTP = txt_OTP.Text;

            if (OTP == otp)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO employee VALUES (@username, @password,@role)", con);
                cmd.Parameters.AddWithValue("@username", txt_user.Text);
                cmd.Parameters.AddWithValue("@password", txt_pass.Text);
                cmd.Parameters.AddWithValue("@role", "customer");
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("UPDATE accounts SET username = @username WHERE account_number = @account_number", con);
                cmd.Parameters.AddWithValue("@account_number", txt_acc.Text);
                cmd.Parameters.AddWithValue("@username", txt_user.Text);
                cmd.ExecuteNonQuery();


                con.Close();
                timer1.Stop();
                MessageBox.Show("You are Registered!");

                Login_Form l = new Login_Form();
                l.Visible = true;
                this.Visible = false;


            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login_Form l = new Login_Form();
            l.Visible = true;
            this.Visible = false;

        }

        private void btn_OTP_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd4 = new SqlCommand("select email FROM accounts WHERE account_number = @account_number", con);
            cmd4.Parameters.AddWithValue("@account_number", txt_acc.Text);

            string email = (string)cmd4.ExecuteScalar();

            otp = GenerateOTP();
            SendOTP(email, otp);

            MessageBox.Show("OTP sent successfully. Please check your email.");
            timer1.Start();
            btn_OTP.Enabled = false;

            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTimerValue--;

            if (currentTimerValue <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Timer Expired");
            }
            else
            {
                txt_timer.Text = currentTimerValue.ToString();
            }

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '\0')
            {
                pictureBox4.BringToFront();
                txt_pass.PasswordChar = '*';
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '*')
            {
                pictureBox3.BringToFront();
                txt_pass.PasswordChar = '\0';
            }
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

