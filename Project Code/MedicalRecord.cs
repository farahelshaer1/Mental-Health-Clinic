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
using System.Configuration;


namespace WindowsFormsApp4
{
    public partial class MedicalRecord : Form
    {
        


        public MedicalRecord()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MedicalRecord_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string strCmd = "select PatId from PatientTbl t1 where not exists(select 1 from MedicalRecordTbl t2 where t2.PatId = t1.PatId)";
            SqlCommand cmd = new SqlCommand(strCmd, con);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            NationalCB.DataSource = ds.Tables[0];
            NationalCB.ValueMember = "PatId";
            NationalCB.Enabled = true;
            this.NationalCB.SelectedIndex = -1;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Close");
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient Obj = new Patient();
            Obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30") ;
            {
                if (NationalCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Select ID!");
                    return;
                }
                if (!prevsuffer.Checked && !noprevsuffer.Checked)
                {
                    MessageBox.Show("Must Select!");
                    return;
                }
                if (!adopted.Checked && !notAdopted.Checked)
                {
                    MessageBox.Show("Must Select!");
                    return;
                }
                if (!MotherTerms.Checked && !motherbad.Checked)
                {
                    MessageBox.Show("Must Select!");
                    return;
                }
                if (!FatherTerms.Checked && !fatherbad.Checked)
                {
                    MessageBox.Show("Must Select!");
                    return;
                }
                if (!married.Checked && !notmarried.Checked)
                {
                    MessageBox.Show("Must Select!");
                    return;
                }
                if (!divorce.Checked && !notdivorce.Checked)
                {
                    MessageBox.Show("Must Select!");
                    return;
                }
                if (!father.Checked && !mother.Checked && !both.Checked && !other.Checked)
                {
                    MessageBox.Show("Must Select!");
                    return;
                }
                string insert = "INSERT INTO MedicalRecordTbl values (@PatNid, @complaint, @prevcomp, @anxiety, " +
                    "@depression, @lossinterest, @sleepChanges, @AppetiteIssues, @PanicAttacks, @Avoidance, @Fatigue, @Adopted, @mother, " +
                    "@father, @married, @divorce, @raised, @currentmed, @prevdiagnosis, @prevmed, @alcohol, @tobacco, @marijuana, @heroin, @cocaine, @painkillers)";
                con.Open();
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.Parameters.Add("@PatNid", SqlDbType.VarChar);
                cmd.Parameters["@PatNid"].Value = NationalCB.SelectedValue.ToString();

                cmd.Parameters.Add("@complaint", SqlDbType.VarChar);
                cmd.Parameters["@complaint"].Value = ComplaintTxt.Text;

                if (prevsuffer.Checked)
                {
                    cmd.Parameters.Add("@prevcomp", SqlDbType.Bit);
                    cmd.Parameters["@prevcomp"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@prevcomp", SqlDbType.Bit);
                    cmd.Parameters["@prevcomp"].Value = 0;
                }
                if (Anxiety.Checked)
                {
                    cmd.Parameters.Add("@anxiety", SqlDbType.Bit);
                    cmd.Parameters["@anxiety"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@anxiety", SqlDbType.Bit);
                    cmd.Parameters["@anxiety"].Value = 0;
                }
                if (Depression.Checked)
                {
                    cmd.Parameters.Add("@depression", SqlDbType.Bit);
                    cmd.Parameters["@depression"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@depression", SqlDbType.Bit);
                    cmd.Parameters["@depression"].Value = 0;
                }
                if (Loss.Checked)
                {
                    cmd.Parameters.Add("@lossinterest", SqlDbType.Bit);
                    cmd.Parameters["@lossinterest"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@lossinterest", SqlDbType.Bit);
                    cmd.Parameters["@lossinterest"].Value = 0;
                }
                if (Sleep.Checked)
                {
                    cmd.Parameters.Add("@sleepChanges", SqlDbType.Bit);
                    cmd.Parameters["@sleepChanges"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@sleepChanges", SqlDbType.Bit);
                    cmd.Parameters["@sleepChanges"].Value = 0;
                }
                if (Appetite.Checked)
                {
                    cmd.Parameters.Add("@AppetiteIssues", SqlDbType.Bit);
                    cmd.Parameters["@AppetiteIssues"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@AppetiteIssues", SqlDbType.Bit);
                    cmd.Parameters["@AppetiteIssues"].Value = 0;
                }
                if (Panic.Checked)
                {
                    cmd.Parameters.Add("@PanicAttacks", SqlDbType.Bit);
                    cmd.Parameters["@PanicAttacks"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@PanicAttacks", SqlDbType.Bit);
                    cmd.Parameters["@PanicAttacks"].Value = 0;
                }
                if (Avoidance.Checked)
                {
                    cmd.Parameters.Add("@Avoidance", SqlDbType.Bit);
                    cmd.Parameters["@Avoidance"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Avoidance", SqlDbType.Bit);
                    cmd.Parameters["@Avoidance"].Value = 0;
                }
                if (Fatigue.Checked)
                {
                    cmd.Parameters.Add("@Fatigue", SqlDbType.Bit);
                    cmd.Parameters["@Fatigue"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Fatigue", SqlDbType.Bit);
                    cmd.Parameters["@Fatigue"].Value = 0;
                }

                if (adopted.Checked)
                {
                    cmd.Parameters.Add("@Adopted", SqlDbType.Bit);
                    cmd.Parameters["@Adopted"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@Adopted", SqlDbType.Bit);
                    cmd.Parameters["@Adopted"].Value = 0;
                }
                if (MotherTerms.Checked)
                {
                    cmd.Parameters.Add("@mother", SqlDbType.VarChar);
                    cmd.Parameters["@mother"].Value = "On Good Terms";
                }
                else
                {
                    cmd.Parameters.Add("@mother", SqlDbType.VarChar);
                    cmd.Parameters["@mother"].Value = "On Bad Terms";
                }
                if (FatherTerms.Checked)
                {
                    cmd.Parameters.Add("@father", SqlDbType.VarChar);
                    cmd.Parameters["@father"].Value = "On Good Terms";
                }
                else
                {
                    cmd.Parameters.Add("@father", SqlDbType.VarChar);
                    cmd.Parameters["@father"].Value = "On Bad Terms";
                }


                if (married.Checked)
                {
                    cmd.Parameters.Add("@married", SqlDbType.Bit);
                    cmd.Parameters["@married"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@married", SqlDbType.Bit);
                    cmd.Parameters["@married"].Value = 0;
                }
                if (divorce.Checked)
                {
                    cmd.Parameters.Add("@divorce", SqlDbType.Bit);
                    cmd.Parameters["@divorce"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@divorce", SqlDbType.Bit);
                    cmd.Parameters["@divorce"].Value = 0;
                }
                
                if (father.Checked == true)
                {

                    
                    cmd.Parameters.Add("@raised", SqlDbType.VarChar);
                    cmd.Parameters["@raised"].Value = "Father";
                }
                else if (mother.Checked == true)
                {
                    cmd.Parameters.Add("@raised", SqlDbType.VarChar);
                    cmd.Parameters["@raised"].Value = "Mother";
                }
                else if (both.Checked == true)
                {
                    cmd.Parameters.Add("@raised", SqlDbType.VarChar);
                    cmd.Parameters["@raised"].Value = "Both";
                }
                else
                {
                    cmd.Parameters.Add("@raised", SqlDbType.VarChar);
                    cmd.Parameters["@raised"].Value = "Other";
                }

                cmd.Parameters.Add("@currentmed", SqlDbType.VarChar);
                cmd.Parameters["@currentmed"].Value = currmedtxt.Text;

                cmd.Parameters.Add("@prevdiagnosis", SqlDbType.VarChar);
                cmd.Parameters["@prevdiagnosis"].Value = prevdiagnosisCB.SelectedItem;

                cmd.Parameters.Add("@prevmed", SqlDbType.VarChar);
                cmd.Parameters["@prevmed"].Value = prevmedCB.SelectedItem;

                if (alcohol.Checked)
                {
                    cmd.Parameters.Add("@alcohol", SqlDbType.Bit);
                    cmd.Parameters["@alcohol"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@alcohol", SqlDbType.Bit);
                    cmd.Parameters["@alcohol"].Value = 0;
                }
                if (tobacco.Checked)
                {
                    cmd.Parameters.Add("@tobacco", SqlDbType.Bit);
                    cmd.Parameters["@tobacco"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@tobacco", SqlDbType.Bit);
                    cmd.Parameters["@tobacco"].Value = 0;
                }
                if (marijuana.Checked)
                {
                    cmd.Parameters.Add("@marijuana", SqlDbType.Bit);
                    cmd.Parameters["@marijuana"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@marijuana", SqlDbType.Bit);
                    cmd.Parameters["@marijuana"].Value = 0;
                }
                if (herion.Checked)
                {
                    cmd.Parameters.Add("@heroin", SqlDbType.Bit);
                    cmd.Parameters["@heroin"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@heroin", SqlDbType.Bit);
                    cmd.Parameters["@heroin"].Value = 0;
                }
                if (cocaine.Checked)
                {
                    cmd.Parameters.Add("@cocaine", SqlDbType.Bit);
                    cmd.Parameters["@cocaine"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@cocaine", SqlDbType.Bit);
                    cmd.Parameters["@cocaine"].Value = 0;
                }
                if (painKillers.Checked)
                {
                    cmd.Parameters.Add("@painkillers", SqlDbType.Bit);
                    cmd.Parameters["@painkillers"].Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@painkillers", SqlDbType.Bit);
                    cmd.Parameters["@painkillers"].Value = 0;
                }
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Saved!");
            




        }

        private void label25_Click_1(object sender, EventArgs e)
        {

        }

        private void NationalCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prevmedCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prevdiagnosisCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void painKillers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cocaine_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void herion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void marijuana_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tobacco_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void alcohol_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void currmedtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click_1(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click_1(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Fatigue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Avoidance_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Panic_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Appetite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Sleep_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Loss_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Depression_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ComplaintTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
