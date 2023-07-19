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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            DisplayDoc();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Женя\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayDoc()
        {
            Con.Open();
            string Query = "Select * from DoctorTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            DoctorDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Clear()
        {
            DNameTb.Text = "";
            DGenCb.SelectedIndex = 0;
            DSpecCb.SelectedIndex = 0;
            DExpTb.Text = "";
            DPhoneTb.Text = "";
            DAddTb.Text = "";
            DPassTb.Text = "";
            Key = 0;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DPhoneTb.Text == "" || DAddTb.Text == "" || DGenCb.SelectedIndex == -1 || DPassTb.Text == "" || DSpecCb.SelectedIndex == -1)
                MessageBox.Show("Missing information");
            else try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DoctorTbl(DocName, DocDOB, DocGen, DocSpec, DocExp, DocPhone, DocAdd, DocPass)values(@DN, @DD, @DG, @DS, @DE, @DP, @DA, @DPA)", Con);
                    cmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                    cmd.Parameters.AddWithValue("@DD", DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DG", DGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DS", DSpecCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DExpTb.Text);
                    cmd.Parameters.AddWithValue("@DP", DPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@DA", DAddTb.Text);
                    cmd.Parameters.AddWithValue("@DPA", DPassTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor added");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        int Key = 0;

        private void DoctorDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DNameTb.Text = DoctorDGV.SelectedRows[0].Cells[1].Value.ToString();
            DOB.Text = DoctorDGV.SelectedRows[0].Cells[2].Value.ToString();
            DGenCb.SelectedItem = DoctorDGV.SelectedRows[0].Cells[3].Value.ToString();
            DSpecCb.SelectedItem = DoctorDGV.SelectedRows[0].Cells[4].Value.ToString();
            DExpTb.Text = DoctorDGV.SelectedRows[0].Cells[5].Value.ToString();
            DPhoneTb.Text = DoctorDGV.SelectedRows[0].Cells[6].Value.ToString();
            DAddTb.Text = DoctorDGV.SelectedRows[0].Cells[7].Value.ToString();
            DPassTb.Text = DoctorDGV.SelectedRows[0].Cells[8].Value.ToString();

            if (DNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DoctorDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EdtBtn_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DPhoneTb.Text == "" || DAddTb.Text == "" || DGenCb.SelectedIndex == -1 || DPassTb.Text == "" || DSpecCb.SelectedIndex == -1)
                MessageBox.Show("Missing information");
            else try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update DoctorTbl set DocName=@DN, DocDOB=@DD, DocGen=@DG, DocSpec=@DS, DocExp=@DE, DocPhone=@DP, DocAdd=@DA, DocPass=@DPA where DocId=@DKey", Con);
                    cmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                    cmd.Parameters.AddWithValue("@DD", DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DG", DGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DS", DSpecCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DExpTb.Text);
                    cmd.Parameters.AddWithValue("@DP", DPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@DA", DAddTb.Text);
                    cmd.Parameters.AddWithValue("@DPA", DPassTb.Text);
                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor updated");
                    Con.Close();
                    DisplayDoc();
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
                MessageBox.Show("Select the doctor");
            else try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from DoctorTbl where DocId=@DKey", Con);
                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor deleted");
                    Con.Close();
                    DisplayDoc();
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

        private void label13_Click(object sender, EventArgs e)
        {
            LabTest obj = new LabTest();
            obj.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Receptionist obj = new Receptionist();
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
