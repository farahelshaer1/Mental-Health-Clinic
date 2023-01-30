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

namespace WindowsFormsApp4
{
    public partial class Appointments : Form
    {
        Functions Con;
        public Appointments()
        {
            InitializeComponent();
            Con = new Functions();
            ShowAppointments();
        }
        private void ShowAppointments()
        {
            try
            {
                string Query = "Select * from AppointmentTbl";
                AppList.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Appointments Obj = new Appointments();
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

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Close");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int Key = 0;

        private void AppList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDcb.Text = AppList.SelectedRows[0].Cells[1].Value.ToString();
            AppDate.Text = AppList.SelectedRows[0].Cells[2].Value.ToString();
            AppTime.Text = AppList.SelectedRows[0].Cells[3].Value.ToString();

            if (IDcb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AppList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UpAppbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDcb.Text == "" || AppTime.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Patient = IDcb.Text;
                    string Appointment_Time = AppTime.SelectedItem.ToString();
                    string Query = "update  AppointmentTbl set Patient =  '{0}' , AppointmentDate = '{1}' , AppointmentTime = '{2}' where AppointmentId = {3}";
                    Query = string.Format(Query, Patient, AppDate.Value.Date, Appointment_Time, Key);
                    Con.SetData(Query);
                    ShowAppointments();
                    MessageBox.Show("Appointment Updated!!");
                    IDcb.Text = "";
                    AppTime.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void DeleteApp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Please select a Patient!");
                }
                else
                {

                    string Query = "delete from  AppointmentTbl where AppointmentId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowAppointments();
                    MessageBox.Show("Appointment Deleted!!");
                    IDcb.Text = "";
                    AppTime.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void SaveApp_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDcb.SelectedIndex == -1 || AppTime.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Patient = IDcb.Text;
                    string Appointment_Time = AppTime.SelectedItem.ToString();
                    string Query = "insert into AppointmentTbl values ( '{0}' , '{1}' , '{2}')";
                    Query = string.Format(Query, Patient, AppDate.Value.Date, Appointment_Time);
                    Con.SetData(Query);
                    ShowAppointments();
                    MessageBox.Show("Appointment Added!!");
                    IDcb.Text = "";
                    AppTime.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        /* private void Appointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myclinicDataSet.PatientTbl' table. You can move, or remove it, as needed.
            this.patientTblTableAdapter.Fill(this.myclinicDataSet.PatientTbl);
        }*/

        private void AppTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Payment Obj = new Payment();
            Obj.Show();
            this.Hide();
        }

        private void PatId_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatId_Enter(object sender, EventArgs e)
        {
            //if (PatId.Text == "            Please Enter Patient's ID")
            //{
            //    PatId.Text = "";
            //    PatId.ForeColor = Color.Black;

            //}
        }

        private void PatId_Leave(object sender, EventArgs e)
        {
            //if (PatId.Text == "")
            //{
            //    PatId.Text = "            Please Enter Patient's ID";
            //    PatId.ForeColor = Color.Silver;

            //}
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string strCmd = "select PatId from PatientTbl";
            SqlCommand cmd = new SqlCommand(strCmd, con);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            IDcb.DataSource = ds.Tables[0];
            IDcb.ValueMember = "PatId";
            IDcb.Enabled = true;
            this.IDcb.SelectedIndex = -1;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void IDcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AppDate_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void AppDate_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today > AppDate.Value)
            {
                MessageBox.Show("Your selected Date is invalid", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppDate.Value = DateTime.Today;
            }
        }
    }

}