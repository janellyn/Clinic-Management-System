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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ClinicMSApp
{
    public partial class Homes : Form
    {
        public Homes()
        {
            InitializeComponent();
            CountPatients();
            CountDoctors();
            CountTests();
            CountHiv();
            if (Login.Role == "Doctor")
            {
                DoctorsLbl.Enabled = false;
                ReceptionistLbl.Enabled = false;
            }
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Женя\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void CountPatients()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PatientTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Patients.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountHiv()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PatientTbl where PatHIV='Positive'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            HivPatients.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountDoctors()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DoctorTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Doctors.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountTests()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from TestTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LabTests.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void PatientsLbl_Click(object sender, EventArgs e)
        {
            Patient obj = new Patient();
            obj.Show();
            this.Hide();
        }

        private void DoctorsLbl_Click(object sender, EventArgs e)
        {
            Doctor obj = new Doctor();
            obj.Show();
            this.Hide();
        }

        private void LaboratoryLbl_Click(object sender, EventArgs e)
        {
            LabTest obj = new LabTest();
            obj.Show();
            this.Hide();
        }

        private void ReceptionistLbl_Click(object sender, EventArgs e)
        {
            Receptionist obj = new Receptionist();
            obj.Show();
            this.Hide();
        }

        private void LogOutLbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

    }
}
