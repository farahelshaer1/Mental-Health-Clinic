using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Patient : Form
    {
        Functions Con;
        public Patient()
        {
            InitializeComponent();
            Con = new Functions();
            ShowPatients();
        }
        private void ShowPatients()
        {
            try
            {
                string Query = "Select * from PatientTbl";
                PatientsList.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        int Key = 0;


        private void PatientsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatNameTxt.Text = PatientsList.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTxt.Text = PatientsList.SelectedRows[0].Cells[2].Value.ToString();
            AddressTxt.Text = PatientsList.SelectedRows[0].Cells[3].Value.ToString();
            PatDOBTxt.Text = PatientsList.SelectedRows[0].Cells[4].Value.ToString();
            GenCh.Text = PatientsList.SelectedRows[0].Cells[5].Value.ToString();
            PatIdTxt.Text = PatientsList.SelectedRows[0].Cells[6].Value.ToString();
            if(PatNameTxt.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PatientsList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PatNameTxt.Text == "" || PhoneTxt.Text == "" || AddressTxt.Text == "" || PatIdTxt.Text == "" || GenCh.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Name = PatNameTxt.Text;
                    string Phone = PhoneTxt.Text;
                    string Address = AddressTxt.Text;
                    string Gender = GenCh.SelectedItem.ToString();
                    string Id = PatIdTxt.Text;
                    string Query = "insert into PatientTbl values ( '{0}' , '{1}' , '{2}' , '{3}' , '{4}' , '{5}' )";
                    Query = string.Format(Query, Name, Phone, Address, PatDOBTxt.Value.Date, Gender, Id);
                    Con.SetData(Query);
                    ShowPatients();
                    MessageBox.Show("Patients Added!!");
                    PatNameTxt.Text = "";
                    PhoneTxt.Text = "";
                    AddressTxt.Text = "";
                    PatIdTxt.Text = "";
                    GenCh.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void UpdatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PatNameTxt.Text == "" || PhoneTxt.Text == "" || AddressTxt.Text == "" || PatIdTxt.Text == "" || GenCh.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Name = PatNameTxt.Text;
                    string Phone = PhoneTxt.Text;
                    string Address = AddressTxt.Text;
                    string Gender = GenCh.SelectedItem.ToString();
                    string Id = PatIdTxt.Text;
                    string Query = "update  PatientTbl set PatName =  '{0}' , PatPhone = '{1}' , PatAdd = '{2}' , PatDOB = '{3}' , PatGender = '{4}' , PatIDD = '{5}' where PatId = {6}"; 
                    Query = string.Format(Query, Name, Phone, Address, PatDOBTxt.Value.Date, Gender, Id, Key);
                    Con.SetData(Query);
                    ShowPatients();
                    MessageBox.Show("Patients Updated!!");
                    PatNameTxt.Text = "";
                    PhoneTxt.Text = "";
                    PatIdTxt.Text = "";
                    AddressTxt.Text = "";
                    GenCh.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if ( Key == 0)
                {
                    MessageBox.Show("Select a patient!");
                }
                else
                {

                    string Query = "delete from  PatientTbl where PatId = {0}; delete from MedicalRecordTbl where Patid = {0}";
                    Query = string.Format(Query , Key);
                    Con.SetData(Query);
                    ShowPatients();
                    MessageBox.Show("Patient Deleted!!");
                    PatNameTxt.Text = "";
                    PhoneTxt.Text = "";
                    PatIdTxt.Text = "";
                    AddressTxt.Text = "";
                    GenCh.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Exit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AdminDashboard Obj = new AdminDashboard();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Patient Obj = new Patient();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Appointments Obj = new Appointments();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Close");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void GenCh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Patientlist_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Payment Obj = new Payment();
            Obj.Show();
            this.Hide();
        }

        private void PhoneTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicalRecord Obj = new MedicalRecord();
            Obj.Show();
            this.Hide();
        }
    }
}

