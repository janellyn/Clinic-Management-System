using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicMSApp
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            DisplayPat();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Женя\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayPat()
        {
            Con.Open();
            string Query = "Select * from PatientTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            PatientDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            PatName.Text = "";
            PatGen.SelectedIndex = 0;
            PatHIV.SelectedIndex = 0;
            PatAdd.Text = "";
            PatAll.Text = "";
            PatPhone.Text = "";
            Key = 0;
        }

        int Key = 0;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (PatName.Text == "" || PatAdd.Text == "" || PatGen.SelectedIndex == -1 || PatPhone.Text == "" || PatHIV.SelectedIndex == -1)
                MessageBox.Show("Missing information");
            else try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PatientTbl(PatName, PatDOB, PatGen, PatAdd, PatAll, PatPhone, PatHIV)values(@PN, @PD, @PG, @PAD, @PAL, @PP, @PH)", Con);
                    cmd.Parameters.AddWithValue("@PN", PatName.Text);
                    cmd.Parameters.AddWithValue("@PG", PatGen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PAD", PatAdd.Text);
                    cmd.Parameters.AddWithValue("@PP", PatPhone.Text);
                    cmd.Parameters.AddWithValue("@PH", PatHIV.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PAL", PatAll.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient added");
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatName.Text = PatientDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatGen.SelectedItem = PatientDGV.SelectedRows[0].Cells[2].Value.ToString();
            PatDOB.Text = PatientDGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAdd.Text = PatientDGV.SelectedRows[0].Cells[4].Value.ToString();
            PatPhone.Text = PatientDGV.SelectedRows[0].Cells[5].Value.ToString();
            PatHIV.SelectedItem = PatientDGV.SelectedRows[0].Cells[6].Value.ToString();
            PatAll.Text = PatientDGV.SelectedRows[0].Cells[7].Value.ToString();

            if (PatName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PatientDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EdtBtn_Click(object sender, EventArgs e)
        {
            if (PatName.Text == "" || PatAdd.Text == "" || PatGen.SelectedIndex == -1 || PatPhone.Text == "" || PatHIV.SelectedIndex == -1)
                MessageBox.Show("Missing information");
            else try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update PatientTbl set PatName=@PN, PatDOB=@PD, PatGen=@PG, PatAdd=@PAD, PatAll=@PAL, PatPhone=@PP, PatHIV=@PH where PatId=@PatKey", Con);
                    cmd.Parameters.AddWithValue("@PN", PatName.Text);
                    cmd.Parameters.AddWithValue("@PG", PatGen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PAD", PatAdd.Text);
                    cmd.Parameters.AddWithValue("@PP", PatPhone.Text);
                    cmd.Parameters.AddWithValue("@PH", PatHIV.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PAL", PatAll.Text);
                    cmd.Parameters.AddWithValue("@PatKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient updated");
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void DltBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
                MessageBox.Show("Select the patient");
            else try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from PatientTbl where PatId=@PatKey", Con);
                    cmd.Parameters.AddWithValue("@PatKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient deleted");
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
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

        private void label14_Click(object sender, EventArgs e)
        {
            Homes obj = new Homes();
            obj.Show();
            this.Hide();
        }
    }
}
