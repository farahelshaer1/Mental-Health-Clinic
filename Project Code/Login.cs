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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       // SqlConnection conn = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (UNameTxt.Text == "Username")
            {
                UNameTxt.Text = "";
                UNameTxt.ForeColor = Color.Black;

            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (UNameTxt.Text == "")
            {
                UNameTxt.Text = "Username";
                UNameTxt.ForeColor = Color.Silver;

            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "Password")
            {
                PasswordTxt.Text = "";
                PasswordTxt.ForeColor = Color.Black;

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "")
            {
                PasswordTxt.Text = "Password";
                PasswordTxt.ForeColor = Color.Silver;

            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (UNameTxt.Text == "" || PasswordTxt.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else if (UNameTxt.Text == "Admin" && PasswordTxt.Text == "Password")
            {
                Patients Obj = new Patients();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
            }
        }

        private void Loginbtn_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toqah\Downloads\myclinic.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Log_in WHERE Username='" + UNameTxt.Text +
                            "' AND Password = '" + PasswordTxt.Text + "'", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                string cmbItemValue = comboBox4.SelectedItem.ToString();
                if (dta.Rows.Count > 0)
                {
                    for (int i =0; i<dta.Rows.Count; i++)
                    {
                        if(dta.Rows[i]["usertype"].ToString()== cmbItemValue)
                        {
                            MessageBox.Show("You are Logged in as " + dta.Rows[i][3]);
                            if (comboBox4.SelectedIndex == 0)
                            {
                                AdminDashboard Obj = new AdminDashboard();
                                Obj.Show();
                                this.Hide();
                            }
                            
                            else
                            {
                                DoctorDashboard f = new DoctorDashboard();
                                f.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UNameTxt.Clear();
                    PasswordTxt.Clear();

                    //To focus username
                    UNameTxt.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            /*finally
            {
                conn.Close();
            }*/

            /*String username, user_password;

            username = UNameTxt.Text;
            user_password = PasswordTxt.Text;

            try
            {
                string query = "SELECT * FROM Log_in WHERE Username = '" + UNameTxt.Text +
                        "' AND Password = '" + PasswordTxt.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    username = UNameTxt.Text;
                    user_password = PasswordTxt.Text;

                    AdminDashboard adminDashboard = new AdminDashboard();
                    this.Hide();
                    adminDashboard.Show();
                }

                else
                {
                    MessageBox.Show("Invalid Login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UNameTxt.Clear();
                    PasswordTxt.Clear();

                    //To focus username
                    UNameTxt.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SignUp Obj = new SignUp();
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

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Close");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}