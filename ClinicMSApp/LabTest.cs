using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicMSApp
{
    public partial class LabTest : Form
    {
        public LabTest()
        {
            InitializeComponent();
            DisplayTest();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Женя\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayTest()
        {
            Con.Open();
            string Query = "Select * from TestTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            LabTestDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            TestName.Text = "";
            TestCost.Text = "";
            Key = 0;
        }

        int Key = 0;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TestName.Text == "" || TestCost.Text == "")
                MessageBox.Show("Missing information");
            else try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TestTbl(TestName, TestCost)values(@TN, @TC)", Con);
                    cmd.Parameters.AddWithValue("@TN", TestName.Text);
                    cmd.Parameters.AddWithValue("@TC", TestCost.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test added");
                    Con.Close();
                    DisplayTest();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TestName.Text == "" || TestCost.Text == "")
                MessageBox.Show("Missing information");
            else try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update TestTbl set TestName=@TN, TestCost=@TC where TestNum=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TN", TestName.Text);
                    cmd.Parameters.AddWithValue("@TC", TestCost.Text);
                    cmd.Parameters.AddWithValue("@TKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test updated");
                    Con.Close();
                    DisplayTest();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
                MessageBox.Show("Select the test");
            else try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from TestTbl where TestNum=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test deleted");
                    Con.Close();
                    DisplayTest();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void LabTestDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TestName.Text = LabTestDGV.SelectedRows[0].Cells[1].Value.ToString();
            TestCost.Text = LabTestDGV.SelectedRows[0].Cells[2].Value.ToString();

            if (TestName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(LabTestDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
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
