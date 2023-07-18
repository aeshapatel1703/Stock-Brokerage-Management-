
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
    public partial class UC_Clients : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aesha Patel\OneDrive\Documents\dbBigBull.mdf;Integrated Security=True;Connect Timeout=30");

        public UC_Clients()
        {
            InitializeComponent();
            FillDataGridView();
            ClearInsertFields();
            fillDropdown();
        }
        private void FillDataGridView()
        {
            SqlCommand cmd = new SqlCommand("Select client_name,phone_no,address,state,brokerage_ratio from tbl_client_master", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            uiDataGridView1.DataSource = dt;
            uiDataGridView1.Columns[0].HeaderText = "Client Name";
            uiDataGridView1.Columns[1].HeaderText = "Phone No";
            uiDataGridView1.Columns[2].HeaderText = "Address";
            uiDataGridView1.Columns[3].HeaderText = "State";
            uiDataGridView1.Columns[4].HeaderText = "Brokerage Ratio";

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

            comboBox1.DisplayMember = "client_name";
            comboBox1.ValueMember = "client_id";
            comboBox1.DataSource = dt;
            comboBox1.SelectedValue = 0;
        }
        public void ClearInsertFields()
        {
            txt_Clients_name.Text = " ";
            txt_Clients_mobile.Text = " ";
            txt_Clients_address.Text = " ";
            txt_Clients_state.Text= " ";
            txt_Clients_brokerage.Text = " ";
        }

        //click-event of Add-client Button
        private void btn_Client_Add_Click(object sender, EventArgs e)
        {
            try 
            { 
                ClientDB cdb = new ClientDB();
                cdb.client_name = txt_Clients_name.Text;
                cdb.phone_no = txt_Clients_mobile.Text;
                cdb.address = txt_Clients_address.Text;
                cdb.state = txt_Clients_state.Text;
                cdb.brokerage_ratio = Convert.ToSingle(txt_Clients_brokerage.Text);

                string query = "insert into tbl_client_master (client_name,phone_no,address,state,brokerage_ratio,client_created_on) values(@cnm,@cmob,@add,@st,@brokerage,@cron)";
                SqlCommand cmd = new SqlCommand(query, conn); 
                cmd.Parameters.Add("cnm",SqlDbType.VarChar).Value=cdb.client_name;
                cmd.Parameters.Add("cmob", SqlDbType.VarChar).Value = cdb.phone_no;
                cmd.Parameters.Add("add", SqlDbType.VarChar).Value = cdb.address;
                cmd.Parameters.Add("st", SqlDbType.VarChar).Value = cdb.state;
                cmd.Parameters.Add("brokerage", SqlDbType.Float).Value = cdb.brokerage_ratio;
                cmd.Parameters.Add("cron", System.DateTime.Now);

                conn.Open(); 
                cmd.ExecuteNonQuery();
                conn.Close();
                FillDataGridView();
                fillDropdown();
                MessageBox.Show("Client Successfully Added!");
                ClearInsertFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        //click-event of Update-client Button
        private void btn_update_client_Click_1(object sender, EventArgs e)
        {
            try
            {
            ClientDB cdb = new ClientDB();
            cdb.client_id = Convert.ToInt32(comboBox1.SelectedValue);
            cdb.client_name = txt_Clients_name.Text;
            cdb.phone_no = txt_Clients_mobile.Text;
            cdb.address = txt_Clients_address.Text;
            cdb.state = txt_Clients_state.Text;
            cdb.brokerage_ratio = Convert.ToSingle(txt_Clients_brokerage.Text);

            string query = "update tbl_client_master set client_name=@cnm,phone_no=@cmob,address=@add,state=@st,brokerage_ratio=@brokerage,client_updated_on=@upon where client_id = " + cdb.client_id;
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.Add("cnm", SqlDbType.VarChar).Value = cdb.client_name;
            cmd.Parameters.Add("cmob", SqlDbType.VarChar).Value = cdb.phone_no;
            cmd.Parameters.Add("add", SqlDbType.VarChar).Value = cdb.address;
            cmd.Parameters.Add("st", SqlDbType.VarChar).Value = cdb.state;
            cmd.Parameters.Add("brokerage", SqlDbType.Float).Value = cdb.brokerage_ratio;
            cmd.Parameters.Add("upon", System.DateTime.Now);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            FillDataGridView();
            fillDropdown();
            MessageBox.Show("Data Updated!");
            ClearInsertFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        //click-event of Delete-client Button
        private void btn_delete_client_Click_1(object sender, EventArgs e)
        {
            try
            {
               ClientDB cdb = new ClientDB();
            cdb.client_id = Convert.ToInt32(comboBox1.SelectedValue);
            string query = "delete from tbl_client_master where client_id = " + cdb.client_id;
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            FillDataGridView();
            fillDropdown();
            MessageBox.Show("Data Deleted!");
            }
            catch (Exception ex1)
            {
                MessageBox.Show("ERROR");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(comboBox1.SelectedValue)!=0)
            {
                ClientDB cdb = new ClientDB();
                cdb.client_id = Convert.ToInt32(comboBox1.SelectedValue);
                string query = "select * from tbl_client_master where client_id = " +cdb.client_id;
                SqlCommand cmd = new SqlCommand(query, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                cdb.client_name = Convert.ToString(dt.Rows[0][1]);
                cdb.phone_no = Convert.ToString(dt.Rows[0][2]);
                cdb.address = Convert.ToString(dt.Rows[0][3]);
                cdb.state = Convert.ToString(dt.Rows[0][4]);
                cdb.brokerage_ratio = Convert.ToSingle(dt.Rows[0][5]);

                txt_Clients_name.Text = cdb.client_name;
                txt_Clients_mobile.Text = cdb.phone_no;
                txt_Clients_address.Text = cdb.address;
                txt_Clients_state.Text = cdb.state;
                txt_Clients_brokerage.Text = cdb.brokerage_ratio.ToString();
            }
            else
            {
                ClearInsertFields();
            }
        }

        private void txt_Clients_brokerage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 110)
            {
                e.Handled = true;
            }
        }

        private void txt_Clients_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_Clients_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_Clients_state_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
