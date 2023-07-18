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
    public partial class UC_Stocks : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aesha Patel\OneDrive\Documents\dbBigBull.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataReader r;
        public UC_Stocks()
        {
            InitializeComponent();
            fillDropdown();
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

            cb_Stocks_Client.DisplayMember = "client_name";
            cb_Stocks_Client.ValueMember = "client_id";
            cb_Stocks_Client.DataSource = dt;
            cb_Stocks_Client.SelectedValue = 0;
        }
        DataTable dt = new DataTable();
        private void btn_View_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select transaction_id,sm.script_name,transaction_date,qty,stock_price,brokerage_value,type,total_price from tbl_transaction_brokerage tb left join tbl_script_master sm on tb.script_id = sm.script_id where tb.client_id = '"+ cb_Stocks_Client.SelectedValue.ToString() + "' and tb.transaction_date >='"+ txt_Dashboard_SDate.Text.ToString() + "' and tb.transaction_date <= '"+ txt_Dashboard_EDate.Text.ToString() + "'", conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            ScriptGridView.DataSource = dt;
            ScriptGridView.Columns[0].HeaderText = "Transaction ID";
            ScriptGridView.Columns[1].HeaderText = "Script Name";
            ScriptGridView.Columns[2].HeaderText = "Date";
            ScriptGridView.Columns[3].HeaderText = "Quantity";
            ScriptGridView.Columns[4].HeaderText = "Stock Price";
            ScriptGridView.Columns[5].HeaderText = "Brokearge Value";
            ScriptGridView.Columns[6].HeaderText = "Type";
            ScriptGridView.Columns[7].HeaderText = "Total Price";
            conn.Close();
        }
    }
}
