using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicMSApp
{
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
            DisplayRec();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Женя\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayRec()
        {
            Con.Open();
            string Query = "Select * from ReceptionistTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            ReceptionistDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (RNameTb.Text == "" || RPhoneTb.Text == "" || RPasswordTb.Text == "" || RAddressTb.Text == "")
                MessageBox.Show("Missing information");
            else try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ReceptionistTbl(RecepName, RecepPhone, RecepAdd, RecepPass)values(@RN, @RP, @RA, @RPA)", Con);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RA", RAddressTb.Text);
                    cmd.Parameters.AddWithValue("@RPA", RPasswordTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist added");
                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        int key = 0;
        private void DltBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
                MessageBox.Show("Select the receptionist");
            else try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ReceptionistTbl where RecepId=@RKey", Con);
                    cmd.Parameters.AddWithValue("@RKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist deleted");
                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void ReceptionistDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RNameTb.Text = ReceptionistDGV.SelectedRows[0].Cells[1].Value.ToString();
            RPhoneTb.Text = ReceptionistDGV.SelectedRows[0].Cells[2].Value.ToString();
            RAddressTb.Text = ReceptionistDGV.SelectedRows[0].Cells[3].Value.ToString();
            RPasswordTb.Text = ReceptionistDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (RNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ReceptionistDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EdBtn_Click(object sender, EventArgs e)
        {
            if (RNameTb.Text == "" || RPhoneTb.Text == "" || RPasswordTb.Text == "" || RAddressTb.Text == "")
                MessageBox.Show("Missing information");
            else try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ReceptionistTbl set RecepName=@RN, RecepPhone=@RP, RecepAdd=@RA, RecepPass=@RPA where RecepId=@RKey", Con);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RA", RAddressTb.Text);
                    cmd.Parameters.AddWithValue("@RPA", RPasswordTb.Text);
                    cmd.Parameters.AddWithValue("@RKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist updated");
                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void Clear()
        {
            RNameTb.Text = "";
            RPhoneTb.Text = "";
            RAddressTb.Text = "";
            RPasswordTb.Text = "";
            key = 0;

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Homes obj = new Homes();
            obj.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
