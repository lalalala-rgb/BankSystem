
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace BankSystem
{
    public partial class ViewAccounts : Form
    {
        public ViewAccounts()
        {
            InitializeComponent();
        }
        int ID = 0;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4Q2ON6T4\\SQLEXPRESS01;Integrated Security=True");


        private void btn_Update_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE accounts SET email = @email, phone = @phone, city = @city WHERE account_number=@account_number", con);
            cmd.Parameters.AddWithValue("@account_number", txt_acc.Text);
            cmd.Parameters.AddWithValue("@phone", Convert.ToInt64(txt_phone.Text));
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@city", cmbAddress.SelectedItem);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Sucessfully!");

        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            Management m = new Management();
            m.Visible = true;
            this.Visible = false;
        }

        private void add_Account_Load(object sender, EventArgs e)
        {
            string[] city = { "Caloocan City", "Navotas City", "Malabon City", "Valenzuela City", "Batangas City", "Manila City", "Taguig City", "Pasig City" };
            foreach (string cities in city)
            {
                cmbAddress.Items.Add(cities);
            }
            displayData();
            Auto_Increment();
        }
        public void displayData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM accounts", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Auto_Increment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(account_number) from [accounts]", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE accounts SET status = 'Inactive' WHERE account_number=@account_number", con);
            cmd.Parameters.AddWithValue("@account_number", txt_acc.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            if (MessageBox.Show("Are you sure this is an inactive account?", "Inactive ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Status changed");
            }
            else
            {
                MessageBox.Show("Status Active");
                this.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_acc.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_phone.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
