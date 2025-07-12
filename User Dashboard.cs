using System.Data.SqlClient;


namespace BankSystem
{


    public partial class User_Dashboard : Form
    {
        Login_Form l = new Login_Form();
        private string username;

        public User_Dashboard(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4Q2ON6T4\\SQLEXPRESS01;Integrated Security=True");


        private void User_Dashboard_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select username FROM accounts WHERE username = @username", con);
            cmd.Parameters.AddWithValue("@username", username);
            lblcustomer.Text = (string)cmd.ExecuteScalar();

            cmd = new SqlCommand("select balance FROM accounts WHERE username = @first_name", con);
            cmd.Parameters.AddWithValue("@first_name", lblcustomer.Text);
            SqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                lblbalance.Text = "₱" + myReader["balance"].ToString();
            }

            con.Close();

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            Customer_History c = new Customer_History(lblcustomer.Text);
            c.Visible = true;
            this.Visible = false;
        }

        private void btn_payBills_Click(object sender, EventArgs e)
        {
            payBills p = new payBills(lblcustomer.Text);
            p.Visible = true;
            this.Visible = false;
        }

        private void btn_sendMoney_Click(object sender, EventArgs e)
        {
            sendMoney s = new sendMoney(lblcustomer.Text);
            s.Visible = true;
            this.Visible = false;
        }
    }
}