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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
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

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Close");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PatNumBt_Click(object sender, EventArgs e)
        {
            /*SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\MASA\Documents\myclinic.mdf; Integrated Security = True; Connect Timeout = 30");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(PatId) from PatientTbl", conn);
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                conn.Close();
                //display data on the page
                PatNumBt.ForeColor = Color.White;
                PatNumBt.Text = rows_count.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
        }

        private void AppNum_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(AppointmentId) from AppointmentTbl", conn);
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                conn.Close();
                //display data on the page
                AppNum.ForeColor = Color.Blue;
                AppNum.Text = rows_count.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PatNumBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(PatId) from PatientTbl", conn);
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                conn.Close();
                //display data on the page
                PatNumBtn.ForeColor = Color.Blue;
                PatNumBtn.Text = rows_count.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void EarningBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(PatPayment) from PaymentTbl", conn);
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                conn.Close();
                //display data on the page
                EarningBtn.ForeColor = Color.Blue;
                EarningBtn.Text = rows_count.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Payment Obj = new Payment();
            Obj.Show();
            this.Hide();
        }
    }
}
