namespace BBA_Software.User_control
{
    partial class UC_Account
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Account));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Account_Edit = new Sunny.UI.UIButton();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txt_Account_Phone = new Sunny.UI.UITextBox();
            this.txt_Account_Email = new Sunny.UI.UITextBox();
            this.txt_Account_Name = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.txt_Account_About = new Sunny.UI.UITextBox();
            this.txt_Account_Script = new Sunny.UI.UITextBox();
            this.txt_Account_Password = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.btn_Account_Edit);
            this.panel1.Controls.Add(this.uiLabel5);
            this.panel1.Controls.Add(this.uiLabel4);
            this.panel1.Controls.Add(this.txt_Account_Phone);
            this.panel1.Controls.Add(this.txt_Account_Email);
            this.panel1.Controls.Add(this.txt_Account_Name);
            this.panel1.Controls.Add(this.txt_Account_Password);
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Controls.Add(this.uiLabel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 698);
            this.panel1.TabIndex = 0;
            // 
            // btn_Account_Edit
            // 
            this.btn_Account_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Account_Edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Account_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account_Edit.Location = new System.Drawing.Point(507, 82);
            this.btn_Account_Edit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Account_Edit.Name = "btn_Account_Edit";
            this.btn_Account_Edit.Radius = 15;
            this.btn_Account_Edit.Size = new System.Drawing.Size(91, 42);
            this.btn_Account_Edit.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Account_Edit.TabIndex = 16;
            this.btn_Account_Edit.Text = "EDIT";
            this.btn_Account_Edit.Click += new System.EventHandler(this.btn_Account_Edit_Click);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel5.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel5.Image")));
            this.uiLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.Location = new System.Drawing.Point(164, 439);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(366, 40);
            this.uiLabel5.TabIndex = 12;
            this.uiLabel5.Text = "       Phone";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel4.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel4.Image")));
            this.uiLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.Location = new System.Drawing.Point(164, 305);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(366, 40);
            this.uiLabel4.TabIndex = 11;
            this.uiLabel4.Text = "       Email";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Account_Phone
            // 
            this.txt_Account_Phone.ButtonSymbol = 61761;
            this.txt_Account_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Account_Phone.Enabled = false;
            this.txt_Account_Phone.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txt_Account_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Account_Phone.Location = new System.Drawing.Point(169, 484);
            this.txt_Account_Phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Account_Phone.Maximum = 2147483647D;
            this.txt_Account_Phone.Minimum = -2147483648D;
            this.txt_Account_Phone.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Account_Phone.Name = "txt_Account_Phone";
            this.txt_Account_Phone.Radius = 15;
            this.txt_Account_Phone.Size = new System.Drawing.Size(342, 34);
            this.txt_Account_Phone.Style = Sunny.UI.UIStyle.Custom;
            this.txt_Account_Phone.TabIndex = 9;
            this.txt_Account_Phone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Account_Phone.Watermark = "";
            // 
            // txt_Account_Email
            // 
            this.txt_Account_Email.ButtonSymbol = 61761;
            this.txt_Account_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Account_Email.Enabled = false;
            this.txt_Account_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Account_Email.Location = new System.Drawing.Point(169, 350);
            this.txt_Account_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Account_Email.Maximum = 2147483647D;
            this.txt_Account_Email.Minimum = -2147483648D;
            this.txt_Account_Email.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Account_Email.Name = "txt_Account_Email";
            this.txt_Account_Email.Radius = 15;
            this.txt_Account_Email.Size = new System.Drawing.Size(342, 34);
            this.txt_Account_Email.TabIndex = 10;
            this.txt_Account_Email.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Account_Email.Watermark = "";
            // 
            // txt_Account_Name
            // 
            this.txt_Account_Name.ButtonSymbol = 61761;
            this.txt_Account_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Account_Name.Enabled = false;
            this.txt_Account_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Account_Name.Location = new System.Drawing.Point(169, 231);
            this.txt_Account_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Account_Name.Maximum = 2147483647D;
            this.txt_Account_Name.Minimum = -2147483648D;
            this.txt_Account_Name.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Account_Name.Name = "txt_Account_Name";
            this.txt_Account_Name.Radius = 15;
            this.txt_Account_Name.Size = new System.Drawing.Size(342, 34);
            this.txt_Account_Name.TabIndex = 9;
            this.txt_Account_Name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Account_Name.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel3.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel3.Image")));
            this.uiLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.Location = new System.Drawing.Point(164, 186);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(366, 40);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "       Name";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.uiLabel1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 60);
            this.panel3.TabIndex = 0;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(236, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(184, 41);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "My Account";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton2.Location = new System.Drawing.Point(525, 82);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Radius = 15;
            this.uiButton2.Size = new System.Drawing.Size(91, 42);
            this.uiButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton2.TabIndex = 17;
            this.uiButton2.Text = "SAVE";
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.uiLabel9);
            this.panel2.Controls.Add(this.uiButton1);
            this.panel2.Controls.Add(this.txt_Account_Script);
            this.panel2.Controls.Add(this.uiButton2);
            this.panel2.Controls.Add(this.btn_Logout);
            this.panel2.Controls.Add(this.uiLabel7);
            this.panel2.Controls.Add(this.txt_Account_About);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(688, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 698);
            this.panel2.TabIndex = 1;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Location = new System.Drawing.Point(255, 592);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(193, 54);
            this.btn_Logout.TabIndex = 21;
            this.btn_Logout.Text = " Logout";
            this.btn_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel9.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel9.Image")));
            this.uiLabel9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel9.Location = new System.Drawing.Point(151, 225);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(366, 40);
            this.uiLabel9.TabIndex = 20;
            this.uiLabel9.Text = "       Script";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel7.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel7.Image")));
            this.uiLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel7.Location = new System.Drawing.Point(151, 410);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(366, 40);
            this.uiLabel7.TabIndex = 18;
            this.uiLabel7.Text = "       About us";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Account_About
            // 
            this.txt_Account_About.ButtonSymbol = 61761;
            this.txt_Account_About.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Account_About.Enabled = false;
            this.txt_Account_About.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txt_Account_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Account_About.Location = new System.Drawing.Point(156, 473);
            this.txt_Account_About.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Account_About.Maximum = 2147483647D;
            this.txt_Account_About.Minimum = -2147483648D;
            this.txt_Account_About.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Account_About.Name = "txt_Account_About";
            this.txt_Account_About.Radius = 15;
            this.txt_Account_About.Size = new System.Drawing.Size(342, 34);
            this.txt_Account_About.Style = Sunny.UI.UIStyle.Custom;
            this.txt_Account_About.TabIndex = 10;
            this.txt_Account_About.Text = "BIG BULL ACCOUNTS ";
            this.txt_Account_About.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Account_About.Watermark = "";
            // 
            // txt_Account_Script
            // 
            this.txt_Account_Script.ButtonSymbol = 61761;
            this.txt_Account_Script.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Account_Script.Enabled = false;
            this.txt_Account_Script.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txt_Account_Script.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Account_Script.Location = new System.Drawing.Point(156, 285);
            this.txt_Account_Script.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Account_Script.Maximum = 2147483647D;
            this.txt_Account_Script.Minimum = -2147483648D;
            this.txt_Account_Script.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Account_Script.Name = "txt_Account_Script";
            this.txt_Account_Script.Radius = 15;
            this.txt_Account_Script.Size = new System.Drawing.Size(342, 34);
            this.txt_Account_Script.Style = Sunny.UI.UIStyle.Custom;
            this.txt_Account_Script.TabIndex = 10;
            this.txt_Account_Script.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Account_Script.Watermark = "";
            // 
            // txt_Account_Password
            // 
            this.txt_Account_Password.ButtonSymbol = 61761;
            this.txt_Account_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Account_Password.Enabled = false;
            this.txt_Account_Password.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txt_Account_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Account_Password.Location = new System.Drawing.Point(169, 624);
            this.txt_Account_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Account_Password.Maximum = 2147483647D;
            this.txt_Account_Password.Minimum = -2147483648D;
            this.txt_Account_Password.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Account_Password.Name = "txt_Account_Password";
            this.txt_Account_Password.Radius = 15;
            this.txt_Account_Password.Size = new System.Drawing.Size(342, 34);
            this.txt_Account_Password.Style = Sunny.UI.UIStyle.Custom;
            this.txt_Account_Password.TabIndex = 10;
            this.txt_Account_Password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Account_Password.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel6.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel6.Image")));
            this.uiLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.Location = new System.Drawing.Point(164, 566);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(366, 40);
            this.uiLabel6.TabIndex = 17;
            this.uiLabel6.Text = "       Password";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.uiLabel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(701, 60);
            this.panel4.TabIndex = 0;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.White;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(264, 9);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(184, 41);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "Setting";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.uiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiButton1.Location = new System.Drawing.Point(538, 277);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 15;
            this.uiButton1.Size = new System.Drawing.Size(91, 42);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 21;
            this.uiButton1.Text = "ADD";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // UC_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1389, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UC_Account";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txt_Account_Name;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txt_Account_Phone;
        private Sunny.UI.UITextBox txt_Account_Email;
        private Sunny.UI.UIButton btn_Account_Edit;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox txt_Account_About;
        private Sunny.UI.UITextBox txt_Account_Script;
        private Sunny.UI.UITextBox txt_Account_Password;
        private Sunny.UI.UILabel uiLabel6;
        private System.Windows.Forms.Button btn_Logout;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
    }
}
