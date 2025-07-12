using System.Data.SqlClient;


namespace BankSystem
{
    public partial class Management : Form
    {

        Add_Customer c = new Add_Customer();
        Withdraw w = new Withdraw();
        ViewAccounts a = new ViewAccounts();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I3HSTVU\\SQLEXPRESS01;Integrated Security=True");

        bool sidebarExpand;
        bool transaction;
        public Management()
        {
            InitializeComponent();
        }
        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_NewCustomer_Click(object sender, EventArgs e)
        {
            c.Visible = true;
            this.Visible = false;

        }
        private void btn_account_Click_1(object sender, EventArgs e)
        {
            a.Visible = true;
            this.Visible = false;
        }

        private void btn_Withdraw_Click_1(object sender, EventArgs e)
        {
            w.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarTime.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sideBarTime.Stop();

                }

            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            sideBarTime.Start();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Management_Load(object sender, EventArgs e)
        {

        }
    }
}
