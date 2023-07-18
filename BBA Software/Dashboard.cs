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

namespace BBA_Software
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            if (btn_MainMenu.Focused == true)
            {
                btn_MainMenu.BackColor = Color.Yellow;
                btn_Dashboard.BackColor = panel1.BackColor;
                uC_Dashboard1.Visible = false;
                uC_Stocks1.Visible = false;
                uC_Clients1.Visible = false;
                uC_Account1.Visible = false;
            }
        }
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            panel1.Height = btn_Dashboard.Height;
            panel1.Top = btn_Dashboard.Top;
            panel1.Left = btn_Dashboard.Left;
            uC_Dashboard1.Visible = true;

            if(btn_Dashboard.Focused == true)
            {
                btn_Dashboard.BackColor = Color.Red;
                btn_MainMenu.BackColor = panel1.BackColor;
                uC_Stocks1.Visible = false;
                uC_Clients1.Visible = false;
                uC_Account1.Visible = false;
            }
        }

        private void btn_Stocks_Click(object sender, EventArgs e)
        {
            panel1.Height = btn_Stocks.Height;
            panel1.Top = btn_Stocks.Top;
            panel1.Left = btn_Stocks.Left;
            uC_Stocks1.Visible = true;

            if (btn_Stocks.Focused == true)
            {
                btn_Stocks.BackColor = Color.Green;
                uC_Dashboard1.Visible = false;
                uC_Clients1.Visible = false;
                uC_Account1.Visible = false;
            }
        }

        private void btn_Clients_Click(object sender, EventArgs e)
        {
            panel1.Height = btn_Clients.Height;
            panel1.Top = btn_Clients.Top;
            panel1.Left = btn_Clients.Left;
            uC_Clients1.Visible = true;
            if(btn_Clients.Focused == true)
            {
                btn_Clients.BackColor = Color.Pink;
                uC_Stocks1.Visible = false;
                uC_Account1.Visible = false;
                uC_Dashboard1.Visible = false;
            }
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            panel1.Height = btn_Account.Height;
            panel1.Top = btn_Account.Top;
            panel1.Left = btn_Account.Left;
            uC_Account1.Visible = true;
            if(btn_Account.Focused == true)
            {
                btn_Account.BackColor = Color.Brown;
                uC_Dashboard1.Visible = false;
                uC_Clients1.Visible = false;
                uC_Stocks1.Visible = false;
            }
        }

        private void btn_MainMenu_Leave(object sender, EventArgs e)
        {
            btn_MainMenu.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_Dashboard_Leave(object sender, EventArgs e)
        {
            btn_Dashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_Stocks_Leave(object sender, EventArgs e)
        {
            btn_Stocks.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_Clients_Leave(object sender, EventArgs e)
        {
            btn_Clients.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_Account_Leave(object sender, EventArgs e)
        {
            btn_Account.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void dash_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dash_Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void dash_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
