using BBA_Software.UserControl;
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
using System.Text.RegularExpressions;

namespace BBA_Software
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aesha Patel\OneDrive\Documents\dbBigBull.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String email = txt_username_login.Text;
            String password = txt_password_login.Text;
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT user_Id FROM tbl_user_master WHERE user_emailid = @email and user_password = @pass", conn);

            command.Parameters.Add("@email", email);
            command.Parameters.Add("@pass", password);
            SqlDataReader reader = command.ExecuteReader();

            bool flag = true;

            while (reader.Read())
            {
                MessageBox.Show("Login Successfull.");
                CurrentUser.userid = reader.GetInt32(0);
                Dashboard f2 = new Dashboard();
                f2.Show();
                this.Hide();
                flag = false;
            }
            if (flag)
            {
                MessageBox.Show("Something was WRONG");
                txt_password_login.Clear();
                txt_username_login.Clear();
            }
            conn.Close();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            //add a new user
            DB db = new DB();
            db.user_name = txt_SignUp_UserName.Text;
            db.user_emailid = txt_SignUp_email.Text;
            db.user_mobile_no = txt_SignUp_mob.Text;
            db.user_password = txt_SignUp_password.Text;

            string query = $"insert into tbl_user_master (user_name,user_emailid,user_mobile_no,user_password,user_created_on) values(@name,@email,@mob,@pass,@cron)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@name", txt_SignUp_UserName.Text);
            command.Parameters.Add("@email", txt_SignUp_email.Text);
            command.Parameters.Add("@mob", txt_SignUp_mob.Text);
            command.Parameters.Add("@pass", txt_SignUp_password.Text);
            command.Parameters.Add("@cron", System.DateTime.Now);

            try
            {
                if (true)
                {
                    //check if the text-boxes contains the Default values 
                    if (!checkTextBoxesValues())
                    {
                        //check if this password equal the confirm password
                        if (txt_SignUp_password.Text.Equals(txt_SignUp_cp.Text))
                        {
                            //check if this username already exists
                            if (checkUsername())
                            {
                                txt_SignUp_UserName.Clear();
                                txt_SignUp_email.Clear();
                                txt_SignUp_mob.Clear();
                                txt_SignUp_password.Clear();
                                txt_SignUp_cp.Clear();
                                throw new ValidationException("This username already exists, Select Another one");  
                            }  
                        }
                        else
                        {
                            txt_SignUp_password.Clear();
                            txt_SignUp_cp.Clear();
                            throw new ValidationException("Invalid Password");   
                        }
                    }
                    else
                    {
                        txt_SignUp_UserName.Clear();
                        txt_SignUp_email.Clear();
                        txt_SignUp_mob.Clear();
                        txt_SignUp_password.Clear();
                        txt_SignUp_cp.Clear();
                        throw new ValidationException("Enter credentials!");   
                    }
                }
                else
                {
                    MessageBox.Show("Something was WRONG");
                    txt_SignUp_UserName.Clear();
                    txt_SignUp_email.Clear();
                    txt_SignUp_mob.Clear();
                    txt_SignUp_password.Clear();
                    txt_SignUp_cp.Clear();
                }

                conn.Open();

                int i = command.ExecuteNonQuery();

                MessageBox.Show(" Sign up Successfull");
                txt_SignUp_UserName.Clear();
                txt_SignUp_email.Clear();
                txt_SignUp_mob.Clear();
                txt_SignUp_password.Clear();
                txt_SignUp_cp.Clear();

                conn.Close();
            }
            catch(ValidationException ve)
            {
                MessageBox.Show(ve.Message);
            }
        }

        //check if the username already exists
        Boolean checkUsername()
        {
            String username = txt_SignUp_UserName.Text;
            DataTable table = new DataTable();

            SqlCommand com = new SqlCommand("SELECT count(*) FROM tbl_user_master WHERE user_name = @user", conn);

            com.Parameters.Add("@user", username);
            conn.Open();
            int i = Convert.ToInt32(com.ExecuteScalar());
            conn.Close();

            //check if this username already exists in database
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //check if the textboxes contains the different values
        Boolean checkTextBoxesValues()
        {
            String username = txt_SignUp_UserName.Text;
            String email = txt_SignUp_email.Text;
            String mob = txt_SignUp_mob.Text;
            String pass = txt_SignUp_password.Text;

            if (username.Equals("") || email.Equals("") || mob.Equals("") || pass.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uiTabControl1.SelectedTab = tabSignup;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uiTabControl1.SelectedTab = tabLogin;
        }

        private void tabLogin_Click(object sender, EventArgs e)
        {

        }

        private void txt_SignUp_mob_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch!= 8)
            {
                e.Handled = true;
            }
        }

        private void txt_SignUp_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_SignUp_email_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if(Regex.IsMatch(txt_SignUp_email.Text,pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txt_SignUp_email, "Please provide valid E-mail Address!!");
                return;
            }
        }

        private void txt_username_login_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txt_username_login.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txt_username_login, "Please provide valid E-mail Address!!");
                return;
            }
        }
    }
}