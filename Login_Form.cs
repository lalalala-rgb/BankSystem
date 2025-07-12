using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
namespace BankSystem
{

    public partial class Login_Form : Form
    {

        public Login_Form()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-6RO4Q35O\\SQLEXPRESS01;Integrated Security=True");


        private void Login_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Select role FROM employee WHERE username = @username AND password = @password", con);

                cmd.Parameters.AddWithValue("@username", txtUser.Text);
                cmd.Parameters.AddWithValue("@password", txtPw.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string userRole = (string)cmd.ExecuteScalar();


                if (dt.Rows.Count > 0 && userRole == "admin")
                {

                    Management q = new Management();
                    q.Visible = true;
                    this.Visible = false;

                }
                else if ((dt.Rows.Count > 0 && userRole == "customer"))
                {
                    User_Dashboard u = new User_Dashboard(txtUser.Text);
                    u.Visible = true;
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
                con.Close();
            }

            catch (Exception exp)
            {
                MessageBox.Show("Invalid!");

            }

        }
        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void label6_Click(object sender, EventArgs e)
        {
            changePass c = new changePass();
            c.Visible = true;
            this.Visible = false;
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtPw.PasswordChar == '\0')
            {
                pictureBox4.BringToFront();
                txtPw.PasswordChar = '*';
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtPw.PasswordChar == '*')
            {
                pictureBox3.BringToFront();
                txtPw.PasswordChar = '\0';
            }
        }
        public void PassValue(string strValue)
        {
            label1.Text = strValue;
        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            signUp s = new signUp();
            s.Visible = true;
            this.Visible = false;
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}