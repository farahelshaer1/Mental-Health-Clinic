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
    public partial class Payment : Form
    {
        
        Functions Con;
        public Payment()
        {
            InitializeComponent();
            Con = new Functions();
            ShowPayments();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        
        private void ShowPayments()
        {
            try
            {
                string Query = "Select * from PaymentTbl";
                PaymentList.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {


            try
            {
                IDcb.Items.Clear();
                conn.Open();
                String id = "SELECT PatId FROM PatientTbl t1 where not exists(select 1 from PaymentTbl t2 where t2.Patient = t1.PatId)";
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
            PaymentTxt.Clear();
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
                if (IDcb.SelectedIndex == -1 || NameTxt.Text == "" || PaymentTxt.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO PaymentTbl (Patient, PatientName, PatPayment) VALUES ( @Patient , @PatientName , @PatPayment )", conn);
                    cmd.Parameters.AddWithValue("@Patient", IDcb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PatientName", NameTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@PatPayment", PaymentTxt.Text.ToString());
                    cmd.ExecuteNonQuery();
                   
                    ShowPayments();
                    MessageBox.Show("Payment Saved!!");
                    //IDcb.SelectedIndex = -1;
 
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

        private void UpdatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDcb.SelectedIndex == -1 || NameTxt.Text == "" || PaymentTxt.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Patient_Id = IDcb.SelectedItem.ToString();
                    string Patient_Name = NameTxt.Text.ToString();
                    string Payment = PaymentTxt.Text.ToString();
                    string Query = "update  PaymentTbl set Patient='"+IDcb.SelectedItem+"',PatientName='"+NameTxt.Text+ "',PatPayment= '" + PaymentTxt.Text + "' where Patient= '" + IDcb.SelectedItem + "'";
                    Query = string.Format(Query, Patient_Id, Patient_Name, Payment, Key);
                    Con.SetData(Query);
                    ShowPayments();
                    MessageBox.Show("Payment Updated!!");
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDcb.SelectedIndex == -1 || NameTxt.Text == "" || PaymentTxt.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {

                    string Query = "delete from  PaymentTbl where Patient= '" + IDcb.SelectedItem + "'";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowPayments();
                    MessageBox.Show("Payment Deleted!!");
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
        int Key = 0;
        private void PaymentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDcb.Text = PaymentList.SelectedRows[0].Cells[0].Value.ToString();
            NameTxt.Text = PaymentList.SelectedRows[0].Cells[1].Value.ToString();
            PaymentTxt.Text = PaymentList.SelectedRows[0].Cells[2].Value.ToString();
            
            if (NameTxt.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PaymentList.SelectedRows[0].Cells[0].Value.ToString());
            }
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Payment Obj = new Payment();
            Obj.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
