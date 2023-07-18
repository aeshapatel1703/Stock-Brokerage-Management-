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

namespace BBA_Software.User_control
{
    public partial class UC_Dashboard : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aesha Patel\OneDrive\Documents\dbBigBull.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataReader r;
        public UC_Dashboard()
        {
            InitializeComponent();
            fillDropdown();
            fillDropdown2();
            ClearInsertFields();
        }

        private void fillDropdown()
        {
            SqlCommand cmd = new SqlCommand("select client_id,client_name from tbl_client_master", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["client_id"] = 0;
            dr["client_name"] = "select";
            dt.Rows.Add(dr);

            cb_Dashboard_Client.DisplayMember = "client_name";
            cb_Dashboard_Client.ValueMember = "client_id";
            cb_Dashboard_Client.DataSource = dt;
            cb_Dashboard_Client.SelectedValue = 0;
        }

        private void fillDropdown2()
        {
            SqlCommand cmd = new SqlCommand("select script_id,script_name from tbl_script_master", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["script_id"] = 0;
            dr["script_name"] = "select";
            dt.Rows.Add(dr);

            cb_Dashboard_Script.DisplayMember = "script_name";
            cb_Dashboard_Script.ValueMember = "script_id";
            cb_Dashboard_Script.DataSource = dt;
            cb_Dashboard_Script.SelectedValue = 0;     
        }

        public void ClearInsertFields()
        {
            txt_Dashboard_Quantity.Text = " ";
            txt_Dashboard_Price.Text = " ";
            cb_Dashboard_Client.Text = " ";
            cb_Dashboard_Script.Text = " ";
            txt_Dashboard_Date.Text = " ";
        }

        private void btn_Dashboard_Buy_Click(object sender, EventArgs e)
        {
            try
            {
                //ClientDB cdb = new ClientDB();
                double client_brokerage_Value = 0.00;
                Console.WriteLine("user_id====>"+CurrentUser.userid);
                Console.WriteLine("QTY: " + txt_Dashboard_Quantity.Text.ToString());
                Console.WriteLine("Price: "+txt_Dashboard_Price.Text.ToString());
                Console.WriteLine("Date: "+txt_Dashboard_Date.Text.ToString());
                Console.WriteLine("ClientID: " + cb_Dashboard_Client.SelectedValue.ToString());
                Console.WriteLine("ScriptID: " + cb_Dashboard_Script.SelectedValue.ToString()); 
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("select brokerage_ratio from tbl_client_master where client_id='" + cb_Dashboard_Client.SelectedValue.ToString() + "'", conn);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);
                    client_brokerage_Value = Convert.ToDouble(dt.Rows[0][0]);
                }
                catch (Exception ex) {
                    Console.WriteLine(ex);
                }
                Console.WriteLine("Client_Brokerage_Value" + client_brokerage_Value);
                int buy_value = Convert.ToInt32(txt_Dashboard_Price.Text) * Convert.ToInt32(txt_Dashboard_Quantity.Text);
                Console.WriteLine("Client Buy Value: " + buy_value);
                double buy_brokerage = buy_value * client_brokerage_Value;
                Console.WriteLine("Client Buy Brokerage: " + buy_brokerage);
                try
                {
                    conn.Open();
                    string query = "insert into tbl_transaction_brokerage (user_id,client_id,script_id,qty,transaction_date,brokerage_value,stock_price,type,delete_status,deleted_by,deleted_on,bill_id,total_price) values(@user_id,@client_id,@script_id,@qty,@transaction_date,@brokerage_value,@stock_price,@type,@deleted_status,@deleted_by,@deleted_on,@bill_id,@total_price)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("user_id", CurrentUser.userid);
                    cmd.Parameters.AddWithValue("client_id", cb_Dashboard_Client.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("script_id", cb_Dashboard_Script.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("qty", txt_Dashboard_Quantity.Text.ToString());
                    cmd.Parameters.AddWithValue("transaction_date", txt_Dashboard_Date.Text.ToString());
                    cmd.Parameters.AddWithValue("brokerage_value", buy_brokerage);
                    cmd.Parameters.AddWithValue("stock_price", txt_Dashboard_Price.Text.ToString());
                    cmd.Parameters.AddWithValue("type", "Buy");
                    cmd.Parameters.AddWithValue("deleted_status", "ACTIVE");
                    cmd.Parameters.AddWithValue("deleted_by", '0');
                    cmd.Parameters.AddWithValue("deleted_on", System.DateTime.Now);
                    cmd.Parameters.AddWithValue("bill_id", '0');
                    cmd.Parameters.AddWithValue("total_price", buy_value);

                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        string msg = "You have successfully brought it!!";
                        string cap = "Conformation";
                        MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string msg = "Something is wrong!!";
                        string cap = "Conformation";
                        MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }     
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btn_Dashboard_Sell_Click(object sender, EventArgs e)
        {
            try
            {
                //ClientDB cdb = new ClientDB();
                double client_brokerage_Value = 0.00;
                Console.WriteLine("user_id====>" + CurrentUser.userid);
                Console.WriteLine("QTY: " + txt_Dashboard_Quantity.Text.ToString());
                Console.WriteLine("Price: " + txt_Dashboard_Price.Text.ToString());
                Console.WriteLine("Date: " + txt_Dashboard_Date.Text.ToString());
                Console.WriteLine("ClientID: " + cb_Dashboard_Client.SelectedValue.ToString());
                Console.WriteLine("ScriptID: " + cb_Dashboard_Script.SelectedValue.ToString());
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("select brokerage_ratio from tbl_client_master where client_id='" + cb_Dashboard_Client.SelectedValue.ToString() + "'", conn);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);
                    client_brokerage_Value = Convert.ToDouble(dt.Rows[0][0]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                Console.WriteLine("Client_Brokerage_Value" + client_brokerage_Value);
                int sell_value = Convert.ToInt32(txt_Dashboard_Price.Text) * Convert.ToInt32(txt_Dashboard_Quantity.Text);
                Console.WriteLine("Client Sell Value: " + sell_value);
                double sell_brokerage = sell_value * client_brokerage_Value;
                Console.WriteLine("Client Sell Brokerage: " + sell_brokerage);
                try
                {
                    conn.Open();
                    string query = "insert into tbl_transaction_brokerage (user_id,client_id,script_id,qty,transaction_date,brokerage_value,stock_price,type,delete_status,deleted_by,deleted_on,bill_id,total_price) values(@user_id,@client_id,@script_id,@qty,@transaction_date,@brokerage_value,@stock_price,@type,@deleted_status,@deleted_by,@deleted_on,@bill_id,@total_price)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("user_id", CurrentUser.userid);
                    cmd.Parameters.AddWithValue("client_id", cb_Dashboard_Client.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("script_id", cb_Dashboard_Script.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("qty", txt_Dashboard_Quantity.Text.ToString());
                    cmd.Parameters.AddWithValue("transaction_date", txt_Dashboard_Date.Text.ToString());
                    cmd.Parameters.AddWithValue("brokerage_value", sell_brokerage);
                    cmd.Parameters.AddWithValue("stock_price", txt_Dashboard_Price.Text.ToString());
                    cmd.Parameters.AddWithValue("type", "Sell");
                    cmd.Parameters.AddWithValue("deleted_status", "ACTIVE");
                    cmd.Parameters.AddWithValue("deleted_by", '0');
                    cmd.Parameters.AddWithValue("deleted_on", System.DateTime.Now);
                    cmd.Parameters.AddWithValue("bill_id", '0');
                    cmd.Parameters.AddWithValue("total_price", sell_value);

                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        string msg = "You sold stocks successfully!!";
                        string cap = "Conformation";
                        MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string msg = "Something is wrong!!";
                        string cap = "Conformation";
                        MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void cb_Dashboard_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cb_Dashboard_Client.SelectedValue.ToString());
        }

        private void txt_Dashboard_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_Dashboard_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
