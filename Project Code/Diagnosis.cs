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
    public partial class Diagnosis : Form
    {
        Functions Con;
        public Diagnosis()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDiagnosis();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        private void ShowDiagnosis()
        {
            try
            {
                string Query = "Select * from DiagnosisTbl";
                DList.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void Diagnosis_Load(object sender, EventArgs e)
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
            PhoneTxt.Clear();
            NameTxt.Clear();
            AddressTxt.Clear();
            gench.Clear();
            PatIdTxt.Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ViewDiagnosis Obj = new ViewDiagnosis();
            Obj.Show();
            this.Hide();
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
                    PhoneTxt.Text = R.GetValue(2).ToString();
                    AddressTxt.Text = R.GetValue(3).ToString();
                    gench.Text = R.GetValue(5).ToString();
                    PatIdTxt.Text = R.GetValue(6).ToString();


                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                conn.Open();
                if (IDcb.SelectedIndex == -1 || NameTxt.Text == "" || PhoneTxt.Text == "" || AddressTxt.Text == "" || gench.Text == "" || PatIdTxt.Text == "" || textBox1.Text == "")
                    {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO DiagnosisTbl (Id, Name, PatPhoneNo, PatAddress, Gender, PatNID, Diagnosis) VALUES ( @Id , @Name , @PatPhoneNo, @PatAddress, @Gender, @PatNID, @Diagnosis )", conn);
                    cmd.Parameters.AddWithValue("@Id", IDcb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Name", NameTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@PatPhoneNo", PhoneTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@PatAddress", AddressTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@Gender", gench.Text.ToString());
                    cmd.Parameters.AddWithValue("@PatNID", PatIdTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@Diagnosis", textBox1.Text.ToString());
                    cmd.ExecuteNonQuery();

                    ShowDiagnosis();
                    MessageBox.Show("Diagnosis Saved!!");
                    //IDcb.SelectedIndex = -1;

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
                if (IDcb.SelectedIndex == -1 || NameTxt.Text =="" || PhoneTxt.Text=="" || AddressTxt.Text=="" || gench.Text=="" || PatIdTxt.Text== "" || textBox1.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Patient_Id = IDcb.SelectedItem.ToString();
                    string Patient_Name = NameTxt.Text.ToString();
                    string phone = PhoneTxt.Text.ToString();
                    string address = AddressTxt.Text.ToString();
                    string gender = gench.Text.ToString();
                    string nationalid = PatIdTxt.Text.ToString();
                    string diagnosis = textBox1.Text.ToString();

                    string Query = "update  DiagnosisTbl set Id='" + IDcb.SelectedItem + "',Name='" + NameTxt.Text + "',PatPhoneNo= '" + PhoneTxt.Text + "',PatAddress='" + AddressTxt.Text + "',Gender='" + gench.Text + "',PatNID='" + PatIdTxt.Text + "',Diagnosis='" + textBox1.Text + "' where Id= '" + IDcb.SelectedItem + "'";
                    Query = string.Format(Query, Patient_Id, Patient_Name, phone, address, gender, nationalid, diagnosis);
                    Con.SetData(Query);
                    ShowDiagnosis();
                    MessageBox.Show("Diagnosis Updated!!");
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int Key = 0;
        private void DList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDcb.Text = DList.SelectedRows[0].Cells[0].Value.ToString();
            NameTxt.Text = DList.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTxt.Text = DList.SelectedRows[0].Cells[2].Value.ToString();
            AddressTxt.Text = DList.SelectedRows[0].Cells[3].Value.ToString();
            gench.Text = DList.SelectedRows[0].Cells[4].Value.ToString();
            PatIdTxt.Text = DList.SelectedRows[0].Cells[5].Value.ToString();
            textBox1.Text = DList.SelectedRows[0].Cells[6].Value.ToString();

            if (IDcb.SelectedIndex == -1)
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DList.SelectedRows[0].Cells[0].Value.ToString());
            }
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

        private void guna2Button2_Click(object sender, EventArgs e)
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DoctorDashboard Obj = new DoctorDashboard();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            AppointmentView Obj = new AppointmentView();
            Obj.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
