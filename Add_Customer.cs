using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace BankSystem
{

    public partial class Add_Customer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-6RO4Q35O\\SQLEXPRESS01;Integrated Security=True");
        public Add_Customer()
        {
            InitializeComponent();

        }


        private void btn_Add_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into accounts (account_number, balance, email, first_name, last_name, middle_name, city, phone) values (@account_number, @balance, @email, @first_name, @last_name, @middle_name, @city, @phone)", con);



            cmd.Parameters.AddWithValue("@account_number", txt_ID.Text);
            cmd.Parameters.AddWithValue("@balance", Convert.ToInt64(txt_balance.Text));
            cmd.Parameters.AddWithValue("@first_name", txt_first.Text);
            cmd.Parameters.AddWithValue("@last_name", txt_last.Text);
            cmd.Parameters.AddWithValue("@middle_name", txt_middle.Text);
            cmd.Parameters.AddWithValue("@city", cmbAddress.SelectedItem);
            cmd.Parameters.AddWithValue("@phone", Convert.ToInt64(txt_phone.Text));




            if (!string.IsNullOrWhiteSpace(txt_email.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (reg.IsMatch(txt_email.Text))
                {
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Added!");
            Auto_Increment();

            txt_balance.Clear();
            txt_email.Clear();
            txt_first.Clear();
            txt_last.Clear();
            txt_middle.Clear();
            cmbAddress.Text = "";
            txt_phone.Clear();


        }



        private void btn_Back_Click(object sender, EventArgs e)
        {
            Management m = new Management();
            m.Visible = true;
            this.Visible = false;
        }
        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void Add_Customer_Load(object sender, EventArgs e)
        {
            string[] city = { "Caloocan City", "Navotas City", "Malabon City", "Valenzuela City", "Batangas City", "Manila City", "Taguig City", "Pasig City" };
            foreach (string cities in city)
            {
                cmbAddress.Items.Add(cities);
            }

            Auto_Increment();
        }


        private void Auto_Increment()
        {
            Random rand1 = new Random();
            int ID = rand1.Next(0000, 9999);
            int ID2 = rand1.Next(0000, 9999);
            int ID3 = rand1.Next(0000, 9999);
            int ID4 = rand1.Next(0000, 9999);
            txt_ID.Text = ID + "-" + ID2 + "-" + ID3 + "-" + ID4.ToString();
        }




        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btn_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;

            }
        }

        private void txt_last_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_middle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }

}
