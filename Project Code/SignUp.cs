using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp4
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        private void label22_Click(object sender, EventArgs e)
        {

        }

        

        private void label9_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
  
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Close");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                conn.Open();
                if (comboBox1.SelectedIndex == -1 || textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Log_in(Username, Password, usertype)VALUES(@Username, @Password, @usertype)", conn);
                    cmd.Parameters.AddWithValue("@usertype", comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text.ToString());
                    cmd.ExecuteNonQuery();

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Sign Up Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Sign Up Failed!");
                    }
                }
            }


            catch (SqlException)
            {
                MessageBox.Show("Sign Up Failed!");
            }
            finally
            {
                conn.Close();


            }





            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

            private void label9_Click_1(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
