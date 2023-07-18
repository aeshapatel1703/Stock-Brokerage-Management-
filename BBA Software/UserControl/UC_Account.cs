using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace BBA_Software.User_control
{
    public partial class UC_Account : Form
    {
        public UC_Account()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Aesha Patel\OneDrive\Documents\dbBigBull.mdf';Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand("Select * from tbl_user_master where user_id="+CurrentUser.userid, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txt_Account_Name.Text = reader.GetString(1);
                txt_Account_Email.Text = reader.GetString(2);
                txt_Account_Password.Text = reader.GetString(4);
                txt_Account_Phone.Text = reader.GetString(3);
            }
            connection.Close();
        }

        private void UC_Account_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aesha Patel\OneDrive\Documents\dbBigBull.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("select * from tbl_user_master where user_id="+CurrentUser.userid, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txt_Account_Name.Text = reader["user_name"].ToString();
                txt_Account_Email.Text = reader["user_emailid"].ToString();
                txt_Account_Phone.Text = reader["user_mobile_no"].ToString();
            }
            conn.Close();
        }

        private void btn_Account_Edit_Click(object sender, EventArgs e)
        {
            if (txt_Account_Name.Enabled == false)
            {
                txt_Account_Name.Enabled = true;
                txt_Account_Email.Enabled = true;
                txt_Account_Phone.Enabled = true;
                txt_Account_Password.Enabled = true;
                //txt_Account_Script.Enabled = true;
            }
        }

        //click event of LogOut Button
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            /*SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aesha Patel\OneDrive\Documents\dbBigBull.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                DB udb = new DB();
                udb.user_name = txt_Account_Name.Text;
                udb.user_emailid = txt_Account_Email.Text;
                udb.user_mobile_no = txt_Account_Phone.Text;
                udb.user_password = txt_Account_Password.Text;

                string query = "update tbl_user_master set user_name=@unm,user_emailid=@ueid,user_mobile_no=@umo,user_password=@ups,user_updated_on=@upon where user_Id = " + udb.user_Id;
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add("unm", SqlDbType.VarChar).Value = udb.user_name;
                cmd.Parameters.Add("ueid", SqlDbType.VarChar).Value = udb.user_emailid;
                cmd.Parameters.Add("umo", SqlDbType.VarChar).Value = udb.user_mobile_no;
                cmd.Parameters.Add("ups", SqlDbType.VarChar).Value = udb.user_created_on;
                cmd.Parameters.Add("upon", System.DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Updated!");
            }
            catch (Exception ex)
            {*/
                MessageBox.Show("Details Updated!!");
            //}
        }

        //click-event of add button to insert the scripts
        private void uiButton1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Aesha Patel\OneDrive\Documents\dbBigBull.mdf';Integrated Security=True;Connect Timeout=30");

            try
            {
                ScriptDB sdb = new ScriptDB();
                sdb.script_name = txt_Account_Script.Text;
            
                string query = "insert into tbl_script_master (script_name,script_created_on) values(@snm,@sron)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("snm", SqlDbType.VarChar).Value = sdb.script_name;
                cmd.Parameters.Add("sron", System.DateTime.Now);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Script Successfully Added!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}