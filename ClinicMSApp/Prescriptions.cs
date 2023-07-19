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
    public partial class Prescriptions : Form
    {
        public Prescriptions()
        {
            InitializeComponent();
            DisplayPres();
            GetDocId();
            GetPatId();
            GetTestId();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Женя\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayPres()
        {
            Con.Open();
            string Query = "Select * from PrescriptionTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            LabTestDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Clear()
        {
            DocId.SelectedIndex = 0;
            PatId.SelectedIndex = 0;
            TestId.SelectedIndex = 0;
            DocName.Text = "";
            PatName.Text = "";
            Test.Text = "";
            Cost.Text = "";
            Medicine.Text = "";
            Prescr.Text = "";
            Key = 0;
        }

        private void GetDocId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select DocId from DoctorTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("DocId", typeof(int));
            dataTable.Load(rdr);
            DocId.ValueMember = "DocId";
            DocId.DataSource = dataTable;
            Con.Close();
        }
        private void GetPatId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select PatId from PatientTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("PatId", typeof(int));
            dataTable.Load(rdr);
            PatId.ValueMember = "PatId";
            PatId.DataSource = dataTable;
            Con.Close();
        }
        private void GetTestId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select TestNum from TestTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("TestNum", typeof(int));
            dataTable.Load(rdr);
            TestId.ValueMember = "TestNum";
            TestId.DataSource = dataTable;
            Con.Close();
        }
        private void GetDocName()
        {
            Con.Open();
            string que = "Select * from DoctorTbl where DocId=" + DocId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(que, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            sql.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                DocName.Text = dr["DocName"].ToString();
            }
            Con.Close();
        }
        private void GetPatName()
        {
            Con.Open();
            string que = "Select * from PatientTbl where PatId=" + PatId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(que, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            sql.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatName.Text = dr["PatName"].ToString();
            }
            Con.Close();
        }
        private void GetTestName()
        {
            Con.Open();
            string que = "Select * from TestTbl where TestNum=" + TestId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(que, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            sql.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Test.Text = dr["TestName"].ToString();
                Cost.Text = dr["TestCost"].ToString();
            }
            Con.Close();
        }

        int Key = 0;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DocId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDocName();
        }

        private void PatId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatName();
        }

        private void TestId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTestName();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DocName.Text == "" || PatName.Text == "" || Test.Text == "")
                MessageBox.Show("Missing information");
            else try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PrescriptionTbl(DocId, DocName, PatId, PatName, LabTestId, LabTestName, Medicines, Cost)values(@DI, @DN, @PI, @PN, @TI, @TN, @M, @C)", Con);
                    cmd.Parameters.AddWithValue("@DI", DocId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", DocName.Text);
                    cmd.Parameters.AddWithValue("@PI", PatId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", PatName.Text);
                    cmd.Parameters.AddWithValue("@TI", TestId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TN", Test.Text);
                    cmd.Parameters.AddWithValue("@M", Medicine.Text);
                    cmd.Parameters.AddWithValue("@C", Cost.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prescription added");
                    Con.Close();
                    DisplayPres();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void LabTestDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Prescr.Text = "";
            Prescr.Text = "                                    My CodeSpace Clinic\n\n" +
                "                                    PRESCRIPTION" +
                "\n********************************************************************************" +
                "\n" + DateTime.Today.Date + "\n\n     Doctor: " + LabTestDGV.SelectedRows[0].Cells[2].Value.ToString() +
                "                                Patient: " + LabTestDGV.SelectedRows[0].Cells[4].Value.ToString() +
                "\n\n     Test: " + LabTestDGV.SelectedRows[0].Cells[6].Value.ToString() +
                "                                     Medicines: " + LabTestDGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Prescr.Text + "\n", new Font("Bookman Old Style", 18, FontStyle.Regular), Brushes.Black, new Point(95, 80));
            e.Graphics.DrawString("\n\n\n\t" + "Thanks!", new Font("Bookman Old Style", 15, FontStyle.Bold), Brushes.Red, new Point(200, 300));
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Patient obj = new Patient();
            obj.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            LabTest obj = new LabTest();
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
