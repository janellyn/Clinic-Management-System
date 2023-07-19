using System.Data;
using System.Data.SqlClient;

namespace ClinicMSApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ResetLbl_Click(object sender, EventArgs e)
        {
            RoleCb.SelectedIndex = 0;
            UserName.Text = "";
            Password.Text = "";
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Æåíÿ\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");
        public static string Role;

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select your position");
            }

            else if (RoleCb.SelectedIndex == 0)
            {
                if (UserName.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Enter both Doctor Name and Password");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DoctorTbl where DocName = '" + UserName.Text + "' and DocPass= '" + Password.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Doctor";
                        Prescriptions obj = new Prescriptions();
                        obj.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Doctor not found");
                    Con.Close();
                }
            }

            else if (RoleCb.SelectedIndex == 1)
            {
                if (UserName.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Enter both Receptionist Name and Password");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from ReceptionistTbl where RecepName = '" + UserName.Text + "' and RecepPass= '" + Password.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Receptionist";
                        Homes obj = new Homes();
                        obj.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Receptionist not found");
                    Con.Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}