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
    public partial class ViewRecord : Form
    {
        public ViewRecord()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        private void NationalCB_SelectedIndexChanged(object sender, EventArgs e)
        {



            //try
            //{
            //    String si = NationalCB.SelectedItem.ToString();
            //    conn.Open();
            //    String query = "SELECT * FROM MedicalRecordTbl WHERE Patid = '" + si + "'";
            //    cmd = new SqlCommand(query, conn);
            //    SqlDataReader R = cmd.ExecuteReader();

            //    while (R.Read())
            //    {
            //        ComplaintTxt.Text = R.GetValue(1).ToString();

            //        if (R.GetBoolean(2) == true)
            //        {
            //            prevsuffer.Checked = true;
            //        }
            //        else
            //            noprevsuffer.Checked = true;

            //        if (R.GetBoolean(3) == true)
            //        {
            //            Anxiety.Checked = true;
            //        }

            //        if (R.GetBoolean(4) == true)
            //        {
            //            Depression.Checked = true;
            //        }

            //        if (R.GetBoolean(5) == true)
            //        {
            //            Loss.Checked = true;
            //        }

            //        if (R.GetBoolean(6) == true)
            //        {
            //            Sleep.Checked = true;
            //        }

            //        if (R.GetBoolean(7) == true)
            //        {
            //            Appetite.Checked = true;
            //        }

            //        if (R.GetBoolean(8) == true)
            //        {
            //            Panic.Checked = true;
            //        }

            //        if (R.GetBoolean(9) == true)
            //        {
            //            Avoidance.Checked = true;
            //        }

            //        if (R.GetBoolean(10) == true)
            //        {
            //            Fatigue.Checked = true;
            //        }



            //        if (prevsuffer.Text.Equals(R.GetValue(2)))
            //        {
            //            prevsuffer.Checked = true;
            //            noprevsuffer.Checked = false;

            //        }
            //        else
            //        {
            //            prevsuffer.Checked = false;
            //            noprevsuffer.Checked = true;

            //        }

            //        if (father.Text.Equals(R.GetValue(16)))
            //        {
            //            father.Checked = true;
            //            mother.Checked = false;
            //            both.Checked = false;
            //            other.Checked = false;
            //        }
            //        else if (mother.Text.Equals(R.GetValue(13)))
            //        {
            //            mother.Checked = true;
            //            father.Checked = false;
            //            both.Checked = false;
            //            other.Checked = false;
            //        }
            //        else if (both.Text.Equals(R.GetValue(13)))
            //        {
            //            both.Checked = true;
            //            mother.Checked = false;
            //            father.Checked = false;
            //            other.Checked = false;

            //        }
            //        else
            //        {
            //            other.Checked = true;
            //            mother.Checked = false;
            //            father.Checked = false;
            //            both.Checked = false;
            //        }

            //        if (MotherTerms.Text.Equals(R.GetValue(12)))
            //        {
            //            MotherTerms.Checked = true;
            //            motherbad.Checked = false;

            //        }
            //        else
            //        {
            //            motherbad.Checked = true;
            //            MotherTerms.Checked = false;
            //        }

            //        if (FatherTerms.Text.Equals(R.GetValue(13)))
            //        {
            //            FatherTerms.Checked = true;
            //            fatherbad.Checked = false;

            //        }
            //        else
            //        {
            //            fatherbad.Checked = true;
            //            FatherTerms.Checked = false;
            //        }

            //        if (married.Text.Equals(R.GetValue(14)))
            //        {
            //            married.Checked = true;
            //            notmarried.Checked = false;

            //        }
            //        else
            //        {
            //            married.Checked = false;
            //            notmarried.Checked = true;

            //        }

            //        if (divorce.Text.Equals(R.GetValue(15)))
            //        {
            //            divorce.Checked = true;
            //            notdivorce.Checked = false;

            //        }
            //        else
            //        {
            //            notdivorce.Checked = false;
            //            divorce.Checked = true;

            //        }
            //        if (adopted.Text.Equals(R.GetValue(11)))
            //        {
            //            adopted.Checked = true;
            //            notAdopted.Checked = false;

            //        }
            //        else
            //        {
            //            adopted.Checked = false;
            //            notAdopted.Checked = true;

            //        }

            //        currmedtxt.Text = R.GetValue(17).ToString();
            //        prevdiagnosisCB.SelectedItem = R.GetValue(18).ToString();
            //        prevmedCB.SelectedItem = R.GetValue(19).ToString();

            //        if (R.GetBoolean(20) == true)
            //        {
            //            alcohol.Checked = true;
            //        }

            //        if (R.GetBoolean(21) == true)
            //        {
            //            tobacco.Checked = true;
            //        }

            //        if (R.GetBoolean(22) == true)
            //        {
            //            marijuana.Checked = true;
            //        }

            //        if (R.GetBoolean(23) == true)
            //        {
            //            herion.Checked = true;
            //        }

            //        if (R.GetBoolean(24) == true)
            //        {
            //            cocaine.Checked = true;
            //        }

            //        if (R.GetBoolean(25) == true)
            //        {
            //            painKillers.Checked = true;
            //        }



            //    }
            //    conn.Close();
            //}
            //catch (Exception ex)
            //        {
            //            MessageBox.Show("Error" + ex);
            //        }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Exit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ViewRecord_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string strcmd = "SELECT Patid from MedicalRecordTbl";
            SqlCommand cmd = new SqlCommand(strcmd, con);
            SqlDataAdapter da = new SqlDataAdapter(strcmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            NationalCB.DataSource = ds.Tables[0];
            NationalCB.ValueMember = "PatId";
            NationalCB.Enabled = true;
            this.NationalCB.SelectedIndex = -1;
            cmd.ExecuteNonQuery();
            con.Close();

            //try
            //{
            //    NationalCB.Items.Clear();
            //    conn.Open();
            //    String id = "SELECT Patid FROM MedicalRecordTbl ORDER BY Patid";
            //    sqlda = new SqlDataAdapter(id, conn);
            //    DataTable dt = new DataTable();
            //    sqlda.Fill(dt);
            //    conn.Close();

            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        NationalCB.Items.Add(dr["Patid"]);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error" + ex);
            //}
            //NationalCB.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                String si = NationalCB.SelectedItem.ToString();
                conn.Open();
                String query = "SELECT * FROM MedicalRecordTbl WHERE Patid = @id";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", NationalCB.SelectedValue.ToString());
                SqlDataReader R = cmd.ExecuteReader();

                while (R.Read())
                {
                    ComplaintTxt.Text = R.GetValue(1).ToString();

                    if (R.GetBoolean(2) == true)
                    {
                        prevsuffer.Checked = true;
                    }
                    else
                        noprevsuffer.Checked = true;

                    if (R.GetBoolean(3) == true)
                    {
                        Anxiety.Checked = true;
                    }

                    if (R.GetBoolean(4) == true)
                    {
                        Depression.Checked = true;
                    }

                    if (R.GetBoolean(5) == true)
                    {
                        Loss.Checked = true;
                    }

                    if (R.GetBoolean(6) == true)
                    {
                        Sleep.Checked = true;
                    }

                    if (R.GetBoolean(7) == true)
                    {
                        Appetite.Checked = true;
                    }

                    if (R.GetBoolean(8) == true)
                    {
                        Panic.Checked = true;
                    }

                    if (R.GetBoolean(9) == true)
                    {
                        Avoidance.Checked = true;
                    }

                    if (R.GetBoolean(10) == true)
                    {
                        Fatigue.Checked = true;
                    }



                    if (prevsuffer.Text.Equals(R.GetValue(2)))
                    {
                        prevsuffer.Checked = true;
                        noprevsuffer.Checked = false;

                    }
                    else
                    {
                        prevsuffer.Checked = false;
                        noprevsuffer.Checked = true;

                    }

                    if (father.Text.Equals(R.GetValue(16)))
                    {
                        father.Checked = true;
                        mother.Checked = false;
                        both.Checked = false;
                        other.Checked = false;
                    }
                    else if (mother.Text.Equals(R.GetValue(13)))
                    {
                        mother.Checked = true;
                        father.Checked = false;
                        both.Checked = false;
                        other.Checked = false;
                    }
                    else if (both.Text.Equals(R.GetValue(13)))
                    {
                        both.Checked = true;
                        mother.Checked = false;
                        father.Checked = false;
                        other.Checked = false;

                    }
                    else
                    {
                        other.Checked = true;
                        mother.Checked = false;
                        father.Checked = false;
                        both.Checked = false;
                    }

                    if (MotherTerms.Text.Equals(R.GetValue(12)))
                    {
                        MotherTerms.Checked = true;
                        motherbad.Checked = false;

                    }
                    else
                    {
                        motherbad.Checked = true;
                        MotherTerms.Checked = false;
                    }

                    if (FatherTerms.Text.Equals(R.GetValue(13)))
                    {
                        FatherTerms.Checked = true;
                        fatherbad.Checked = false;

                    }
                    else
                    {
                        fatherbad.Checked = true;
                        FatherTerms.Checked = false;
                    }

                    if (married.Text.Equals(R.GetValue(14)))
                    {
                        married.Checked = true;
                        notmarried.Checked = false;

                    }
                    else
                    {
                        married.Checked = false;
                        notmarried.Checked = true;

                    }

                    if (divorce.Text.Equals(R.GetValue(15)))
                    {
                        divorce.Checked = true;
                        notdivorce.Checked = false;

                    }
                    else
                    {
                        notdivorce.Checked = false;
                        divorce.Checked = true;

                    }
                    if (adopted.Text.Equals(R.GetValue(11)))
                    {
                        adopted.Checked = true;
                        notAdopted.Checked = false;

                    }
                    else
                    {
                        adopted.Checked = false;
                        notAdopted.Checked = true;

                    }

                    currmedtxt.Text = R.GetValue(17).ToString();
                    prevdiagnosisCB.SelectedItem = R.GetValue(18).ToString();
                    prevmedCB.SelectedItem = R.GetValue(19).ToString();

                    if (R.GetBoolean(20) == true)
                    {
                        alcohol.Checked = true;
                    }

                    if (R.GetBoolean(21) == true)
                    {
                        tobacco.Checked = true;
                    }

                    if (R.GetBoolean(22) == true)
                    {
                        marijuana.Checked = true;
                    }

                    if (R.GetBoolean(23) == true)
                    {
                        herion.Checked = true;
                    }

                    if (R.GetBoolean(24) == true)
                    {
                        cocaine.Checked = true;
                    }

                    if (R.GetBoolean(25) == true)
                    {
                        painKillers.Checked = true;
                    }



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
