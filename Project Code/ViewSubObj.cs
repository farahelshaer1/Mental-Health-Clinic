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
    public partial class ViewSubObj : Form
    {
        public ViewSubObj()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();

        private void BackBtn_Click(object sender, EventArgs e)
        {
            SubObj Obj = new SubObj();
            Obj.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewSubObj_Load(object sender, EventArgs e)
        {
            try
            {
                IDcb.Items.Clear();
                conn.Open();
                String id = "SELECT PatId FROM PatientTbl t1 where exists(select 1 from SubObTbl t2 where t2.Id = t1.PatId)";
                sqlda = new SqlDataAdapter(id, conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                conn.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    IDcb.Items.Add(dr["PatId"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            IDcb.ResetText();
            NameTxt.Clear();
            SubTxt.Clear();
            ObjTxt.Clear();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Exit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void IDcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String si = IDcb.SelectedItem.ToString();
                conn.Open();
                String query = "SELECT * FROM SubObTbl WHERE Id = '" + si + "'";
                cmd = new SqlCommand(query, conn);
                SqlDataReader R = cmd.ExecuteReader();

                while (R.Read())
                {
                    NameTxt.Text = R.GetValue(1).ToString();
                   
                    SubTxt.Text = R.GetValue(2).ToString();
                    ObjTxt.Text = R.GetValue(3).ToString();

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Diagnosis Obj = new Diagnosis();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            ViewRecord Obj = new ViewRecord();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DoctorPatient Obj = new DoctorPatient();
            Obj.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Diagnosis Obj = new Diagnosis();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            SubObj Obj = new SubObj();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            ViewRecord Obj = new ViewRecord();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            DoctorPatient Obj = new DoctorPatient();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            AppointmentView Obj = new AppointmentView();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DoctorDashboard Obj = new DoctorDashboard();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddPrescription Obj = new AddPrescription();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
