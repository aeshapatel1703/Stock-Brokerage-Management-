namespace BBA_Software
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_Clients = new System.Windows.Forms.Button();
            this.btn_Stocks = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dash_Close = new System.Windows.Forms.Button();
            this.dash_Max = new System.Windows.Forms.Button();
            this.dash_min = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            /*this.uC_Account1 = new BBA_Software.User_control.UC_Account();
            this.uC_Account1.TopLevel = false;
            this.uC_Clients1 = new BBA_Software.User_control.UC_Clients();
            this.uC_Clients1.TopLevel = false;
            this.uC_Stocks1 = new BBA_Software.User_control.UC_Stocks();
            this.uC_Stocks1.TopLevel = false;
            this.uC_Dashboard1 = new BBA_Software.User_control.UC_Dashboard();
            uC_Dashboard1.TopLevel = false;*/
            this.uC_Account1 = new BBA_Software.User_control.UC_Account();
            this.uC_Account1.TopLevel = false;
            this.uC_Clients1 = new BBA_Software.User_control.UC_Clients();
            this.uC_Clients1.TopLevel = false;
            this.uC_Stocks1 = new BBA_Software.User_control.UC_Stocks();
            this.uC_Stocks1.TopLevel = false;
            this.uC_Dashboard1 = new BBA_Software.User_control.UC_Dashboard();
            uC_Dashboard1.TopLevel = false;
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_MainMenu);
            this.panel1.Controls.Add(this.btn_Account);
            this.panel1.Controls.Add(this.btn_Clients);
            this.panel1.Controls.Add(this.btn_Stocks);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 785);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 175);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.FlatAppearance.BorderSize = 0;
            this.btn_MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainMenu.ForeColor = System.Drawing.Color.White;
            this.btn_MainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btn_MainMenu.Image")));
            this.btn_MainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MainMenu.Location = new System.Drawing.Point(8, 182);
            this.btn_MainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(229, 62);
            this.btn_MainMenu.TabIndex = 4;
            this.btn_MainMenu.Text = "    Home";
            this.btn_MainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MainMenu.UseVisualStyleBackColor = true;
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click);
            this.btn_MainMenu.Leave += new System.EventHandler(this.btn_MainMenu_Leave);
            // 
            // btn_Account
            // 
            this.btn_Account.FlatAppearance.BorderSize = 0;
            this.btn_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.ForeColor = System.Drawing.Color.White;
            this.btn_Account.Image = ((System.Drawing.Image)(resources.GetObject("btn_Account.Image")));
            this.btn_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Account.Location = new System.Drawing.Point(8, 496);
            this.btn_Account.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(229, 62);
            this.btn_Account.TabIndex = 6;
            this.btn_Account.Text = "    Account";
            this.btn_Account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            this.btn_Account.Leave += new System.EventHandler(this.btn_Account_Leave);
            // 
            // btn_Clients
            // 
            this.btn_Clients.FlatAppearance.BorderSize = 0;
            this.btn_Clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clients.ForeColor = System.Drawing.Color.White;
            this.btn_Clients.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clients.Image")));
            this.btn_Clients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clients.Location = new System.Drawing.Point(8, 426);
            this.btn_Clients.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clients.Name = "btn_Clients";
            this.btn_Clients.Size = new System.Drawing.Size(229, 62);
            this.btn_Clients.TabIndex = 5;
            this.btn_Clients.Text = "    Clients";
            this.btn_Clients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Clients.UseVisualStyleBackColor = true;
            this.btn_Clients.Click += new System.EventHandler(this.btn_Clients_Click);
            this.btn_Clients.Leave += new System.EventHandler(this.btn_Clients_Leave);
            // 
            // btn_Stocks
            // 
            this.btn_Stocks.FlatAppearance.BorderSize = 0;
            this.btn_Stocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stocks.ForeColor = System.Drawing.Color.White;
            this.btn_Stocks.Image = ((System.Drawing.Image)(resources.GetObject("btn_Stocks.Image")));
            this.btn_Stocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Stocks.Location = new System.Drawing.Point(5, 356);
            this.btn_Stocks.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Stocks.Name = "btn_Stocks";
            this.btn_Stocks.Size = new System.Drawing.Size(232, 62);
            this.btn_Stocks.TabIndex = 4;
            this.btn_Stocks.Text = "     Stocks";
            this.btn_Stocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Stocks.UseVisualStyleBackColor = true;
            this.btn_Stocks.Click += new System.EventHandler(this.btn_Stocks_Click);
            this.btn_Stocks.Leave += new System.EventHandler(this.btn_Stocks_Leave);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dashboard.Image")));
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(8, 286);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(229, 62);
            this.btn_Dashboard.TabIndex = 3;
            this.btn_Dashboard.Text = "    Dashboard";
            this.btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            this.btn_Dashboard.Leave += new System.EventHandler(this.btn_Dashboard_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.dash_Close);
            this.panel3.Controls.Add(this.dash_Max);
            this.panel3.Controls.Add(this.dash_min);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(245, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1389, 87);
            this.panel3.TabIndex = 2;
            // 
            // dash_Close
            // 
            this.dash_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dash_Close.Image = ((System.Drawing.Image)(resources.GetObject("dash_Close.Image")));
            this.dash_Close.Location = new System.Drawing.Point(1215, 24);
            this.dash_Close.Name = "dash_Close";
            this.dash_Close.Size = new System.Drawing.Size(51, 42);
            this.dash_Close.TabIndex = 8;
            this.dash_Close.UseVisualStyleBackColor = false;
            this.dash_Close.Click += new System.EventHandler(this.dash_Close_Click);
            // 
            // dash_Max
            // 
            this.dash_Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dash_Max.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.dash_Max.FlatAppearance.BorderSize = 0;
            this.dash_Max.Image = ((System.Drawing.Image)(resources.GetObject("dash_Max.Image")));
            this.dash_Max.Location = new System.Drawing.Point(1155, 24);
            this.dash_Max.Name = "dash_Max";
            this.dash_Max.Size = new System.Drawing.Size(51, 42);
            this.dash_Max.TabIndex = 7;
            this.dash_Max.UseVisualStyleBackColor = false;
            this.dash_Max.Click += new System.EventHandler(this.dash_Max_Click);
            // 
            // dash_min
            // 
            this.dash_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dash_min.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.dash_min.FlatAppearance.BorderSize = 0;
            this.dash_min.Image = ((System.Drawing.Image)(resources.GetObject("dash_min.Image")));
            this.dash_min.Location = new System.Drawing.Point(1089, 24);
            this.dash_min.Name = "dash_min";
            this.dash_min.Size = new System.Drawing.Size(51, 42);
            this.dash_min.TabIndex = 6;
            this.dash_min.UseVisualStyleBackColor = false;
            this.dash_min.Click += new System.EventHandler(this.dash_min_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.uC_Account1);
            this.panel4.Controls.Add(this.uC_Clients1);
            this.panel4.Controls.Add(this.uC_Stocks1);
            this.panel4.Controls.Add(this.uC_Dashboard1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(245, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1389, 698);
            this.panel4.TabIndex = 3;
            // 
            // uC_Account1
            // 
            this.uC_Account1.BackColor = System.Drawing.Color.White;
            this.uC_Account1.ClientSize = new System.Drawing.Size(1389, 698);
            this.uC_Account1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Account1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.uC_Account1.Location = new System.Drawing.Point(0, 0);
            this.uC_Account1.Name = "uC_Account1";
            this.uC_Account1.Visible = false;
            // 
            // uC_Clients1
            // 
            this.uC_Clients1.BackColor = System.Drawing.Color.White;
            this.uC_Clients1.ClientSize = new System.Drawing.Size(1389, 698);
            this.uC_Clients1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Clients1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.uC_Clients1.Location = new System.Drawing.Point(0, 0);
            this.uC_Clients1.Name = "uC_Clients1";
            this.uC_Clients1.Visible = false;
            // 
            // uC_Stocks1
            // 
            this.uC_Stocks1.BackColor = System.Drawing.Color.White;
            this.uC_Stocks1.ClientSize = new System.Drawing.Size(1389, 698);
            this.uC_Stocks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Stocks1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.uC_Stocks1.Location = new System.Drawing.Point(0, 0);
            this.uC_Stocks1.Name = "uC_Stocks1";
            this.uC_Stocks1.Visible = false;
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_Dashboard1.ClientSize = new System.Drawing.Size(1269, 698);
            this.uC_Dashboard1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.uC_Dashboard1.Location = new System.Drawing.Point(-3, 0);
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1634, 785);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_MainMenu;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_Clients;
        private System.Windows.Forms.Button btn_Stocks;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private User_control.UC_Dashboard uC_Dashboard1;
        private User_control.UC_Stocks uC_Stocks1;
        private User_control.UC_Clients uC_Clients1;
        private User_control.UC_Account uC_Account1;
        private System.Windows.Forms.Button dash_min;
        private System.Windows.Forms.Button dash_Max;
        private System.Windows.Forms.Button dash_Close;
    }
}