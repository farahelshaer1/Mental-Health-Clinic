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

    public partial class AddPrescription : Form
    {
        Functions Con;
        public AddPrescription()
        {
            InitializeComponent();
            Con = new Functions();
            ShowPrescription();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        private void ShowPrescription()
        {
            try
            {
                string Query = "Select * from Prescription_Tbl";
                PrescriptionList.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {
            try
            {
                IDcb.Items.Clear();
                conn.Open();
                String id = "SELECT PatId FROM PatientTbl t1 where exists(select 1 from AppointmentTbl t2 where t2.Patient = t1.PatId)";
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
            comboBox2.ResetText();
            comboBox1.ResetText();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
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
                String query = "SELECT * FROM PatientTbl WHERE PatId = '" + si + "'";
                cmd = new SqlCommand(query, conn);
                SqlDataReader R = cmd.ExecuteReader();

                while (R.Read())
                {
                    NameTxt.Text = R.GetValue(1).ToString();
                    comboBox2.Text = R.GetValue(5).ToString();



                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        int Key = 0;
        private void UpdatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDcb.SelectedIndex == -1 || NameTxt.Text == "" || comboBox2.SelectedIndex == -1 || comboBox1.SelectedIndex == -1 ||textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Patient_Id = IDcb.SelectedItem.ToString();
                    string Patient_Name = NameTxt.Text.ToString();
                    string Gender = comboBox2.SelectedIndex.ToString();
                    string DrgName = comboBox1.SelectedIndex.ToString();
                    string SDrName = textBox1.Text.ToString();
                    string PresDate = AppDate.Text.ToString();
                    string Drgdes = textBox2.Text.ToString();
                    string DcName = textBox3.Text.ToString();

                    string Query = "update  Prescription_Tbl set PatId='" + IDcb.SelectedItem + "',PatName='" + NameTxt.Text + "',PatGender= '" + comboBox2.SelectedIndex + "',DrgName='" + comboBox1.Text + "',SDrgName='" + textBox1.Text + "',PresDate='" + AppDate.Text + "',DrDescription='" + textBox2.Text + "',DcName='" + textBox3.Text + "' where PatId= '" + IDcb.SelectedItem + "'";
                    Query = string.Format(Query, Patient_Id, Patient_Name, Gender, DrgName, SDrName, PresDate, Drgdes, DcName);
                    Con.SetData(Query);
                    ShowPrescription();
                    MessageBox.Show("Prescription Updated!!");
                    //NameTxt.Text = "";
                    //PaymentTxt.Text = "";
                    //IDcb.SelectedIndex = -1;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void PrescriptionList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDcb.Text = PrescriptionList.SelectedRows[0].Cells[0].Value.ToString();
            NameTxt.Text = PrescriptionList.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.Text = PrescriptionList.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = PrescriptionList.SelectedRows[0].Cells[3].Value.ToString();
            textBox1.Text = PrescriptionList.SelectedRows[0].Cells[4].Value.ToString();
            AppDate.Text = PrescriptionList.SelectedRows[0].Cells[5].Value.ToString();
            textBox2.Text = PrescriptionList.SelectedRows[0].Cells[6].Value.ToString();
            textBox3.Text = PrescriptionList.SelectedRows[0].Cells[7].Value.ToString();
            if (IDcb.SelectedIndex == -1)

            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PrescriptionList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDcb.SelectedIndex == -1 || NameTxt.Text == "" || comboBox2.SelectedIndex == -1 || comboBox1.SelectedIndex == -1 || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {

                    string Query = "delete from  Prescription_Tbl where PatId= '" + IDcb.SelectedItem + "'";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowPrescription();
                    MessageBox.Show("Prescription Deleted!!");
                    NameTxt.Text = "";
                    comboBox2.SelectedIndex = -1;
                    comboBox1.SelectedIndex = -1;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    IDcb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                conn.Open();
                if (IDcb.SelectedIndex == -1 || NameTxt.Text == "" || comboBox2.SelectedIndex == -1 || comboBox1.SelectedIndex == -1  || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Prescription_Tbl (PatId, PatName, PatGender, DrgName, SDrgName, PresDate, DrDescription,DcName) VALUES ( @PatId, @PatName, @PatGender, @DrgName, @SDrgName, @PresDate, @DrDescription,@DcName)", conn);
                    cmd.Parameters.AddWithValue("@PatId", IDcb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PatName", NameTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@PatGender", comboBox2.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DrgName", comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDrgName", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@PresDate", AppDate.Text.ToString());
                    cmd.Parameters.AddWithValue("@DrDescription", textBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@DcName", textBox3.Text.ToString());

                    cmd.ExecuteNonQuery();

                    ShowPrescription();
                    MessageBox.Show("Prescription Saved!!");
                    //IDcb.SelectedIndex = -1;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DoctorPatient Obj = new DoctorPatient();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            ViewRecord Obj = new ViewRecord();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            SubObj Obj = new SubObj();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Diagnosis Obj = new Diagnosis();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddPrescription Obj = new AddPrescription();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewPrescription Obj = new ViewPrescription();
            Obj.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
