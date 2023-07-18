namespace BBA_Software.User_control
{
    partial class UC_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            this.txt_Dashboard_Quantity = new Sunny.UI.UITextBox();
            this.txt_Dashboard_Price = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.cb_Dashboard_Client = new Sunny.UI.UIComboBox();
            this.cb_Dashboard_Script = new Sunny.UI.UIComboBox();
            this.btn_Dashboard_Buy = new Sunny.UI.UIButton();
            this.btn_Dashboard_Sell = new Sunny.UI.UIButton();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.txt_Dashboard_Date = new Sunny.UI.UIDatePicker();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // txt_Dashboard_Quantity
            // 
            this.txt_Dashboard_Quantity.ButtonSymbol = 61761;
            this.txt_Dashboard_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Dashboard_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dashboard_Quantity.Location = new System.Drawing.Point(536, 306);
            this.txt_Dashboard_Quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Dashboard_Quantity.Maximum = 2147483647D;
            this.txt_Dashboard_Quantity.Minimum = -2147483648D;
            this.txt_Dashboard_Quantity.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Dashboard_Quantity.Name = "txt_Dashboard_Quantity";
            this.txt_Dashboard_Quantity.Radius = 15;
            this.txt_Dashboard_Quantity.Size = new System.Drawing.Size(342, 34);
            this.txt_Dashboard_Quantity.TabIndex = 8;
            this.txt_Dashboard_Quantity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Dashboard_Quantity.Watermark = "Enter Quantity";
            this.txt_Dashboard_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dashboard_Quantity_KeyPress);
            // 
            // txt_Dashboard_Price
            // 
            this.txt_Dashboard_Price.ButtonSymbol = 61761;
            this.txt_Dashboard_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Dashboard_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dashboard_Price.Location = new System.Drawing.Point(536, 409);
            this.txt_Dashboard_Price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Dashboard_Price.Maximum = 2147483647D;
            this.txt_Dashboard_Price.Minimum = -2147483648D;
            this.txt_Dashboard_Price.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Dashboard_Price.Name = "txt_Dashboard_Price";
            this.txt_Dashboard_Price.Radius = 15;
            this.txt_Dashboard_Price.Size = new System.Drawing.Size(342, 34);
            this.txt_Dashboard_Price.TabIndex = 9;
            this.txt_Dashboard_Price.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Dashboard_Price.Watermark = "Enter Price ";
            this.txt_Dashboard_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dashboard_Price_KeyPress);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel2.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel2.Image")));
            this.uiLabel2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uiLabel2.Location = new System.Drawing.Point(531, 364);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(218, 40);
            this.uiLabel2.TabIndex = 10;
            this.uiLabel2.Text = "       Price";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel3.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel3.Image")));
            this.uiLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.Location = new System.Drawing.Point(531, 68);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(332, 40);
            this.uiLabel3.TabIndex = 11;
            this.uiLabel3.Text = "       Select Client";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel4.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel4.Image")));
            this.uiLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.Location = new System.Drawing.Point(531, 163);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(253, 40);
            this.uiLabel4.TabIndex = 12;
            this.uiLabel4.Text = "       Select Script";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_Dashboard_Client
            // 
            this.cb_Dashboard_Client.DataSource = null;
            this.cb_Dashboard_Client.FillColor = System.Drawing.Color.White;
            this.cb_Dashboard_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Dashboard_Client.Location = new System.Drawing.Point(536, 113);
            this.cb_Dashboard_Client.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Dashboard_Client.MinimumSize = new System.Drawing.Size(63, 0);
            this.cb_Dashboard_Client.Name = "cb_Dashboard_Client";
            this.cb_Dashboard_Client.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cb_Dashboard_Client.Radius = 15;
            this.cb_Dashboard_Client.Size = new System.Drawing.Size(342, 34);
            this.cb_Dashboard_Client.TabIndex = 13;
            this.cb_Dashboard_Client.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_Dashboard_Client.Watermark = "Choose Client";
            this.cb_Dashboard_Client.SelectedIndexChanged += new System.EventHandler(this.cb_Dashboard_Client_SelectedIndexChanged);
            // 
            // cb_Dashboard_Script
            // 
            this.cb_Dashboard_Script.DataSource = null;
            this.cb_Dashboard_Script.FillColor = System.Drawing.Color.White;
            this.cb_Dashboard_Script.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Dashboard_Script.Location = new System.Drawing.Point(536, 208);
            this.cb_Dashboard_Script.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Dashboard_Script.MinimumSize = new System.Drawing.Size(63, 0);
            this.cb_Dashboard_Script.Name = "cb_Dashboard_Script";
            this.cb_Dashboard_Script.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cb_Dashboard_Script.Radius = 15;
            this.cb_Dashboard_Script.Size = new System.Drawing.Size(342, 34);
            this.cb_Dashboard_Script.TabIndex = 14;
            this.cb_Dashboard_Script.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_Dashboard_Script.Watermark = "Choose Script";
            // 
            // btn_Dashboard_Buy
            // 
            this.btn_Dashboard_Buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dashboard_Buy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Dashboard_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard_Buy.Location = new System.Drawing.Point(536, 611);
            this.btn_Dashboard_Buy.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Dashboard_Buy.Name = "btn_Dashboard_Buy";
            this.btn_Dashboard_Buy.Radius = 15;
            this.btn_Dashboard_Buy.Size = new System.Drawing.Size(150, 50);
            this.btn_Dashboard_Buy.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Dashboard_Buy.TabIndex = 15;
            this.btn_Dashboard_Buy.Text = "BUY";
            this.btn_Dashboard_Buy.Click += new System.EventHandler(this.btn_Dashboard_Buy_Click);
            // 
            // btn_Dashboard_Sell
            // 
            this.btn_Dashboard_Sell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dashboard_Sell.FillColor = System.Drawing.Color.Red;
            this.btn_Dashboard_Sell.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Dashboard_Sell.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Dashboard_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard_Sell.Location = new System.Drawing.Point(728, 611);
            this.btn_Dashboard_Sell.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Dashboard_Sell.Name = "btn_Dashboard_Sell";
            this.btn_Dashboard_Sell.Radius = 15;
            this.btn_Dashboard_Sell.Size = new System.Drawing.Size(150, 50);
            this.btn_Dashboard_Sell.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Dashboard_Sell.TabIndex = 16;
            this.btn_Dashboard_Sell.Text = "SELL";
            this.btn_Dashboard_Sell.Click += new System.EventHandler(this.btn_Dashboard_Sell_Click);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel5.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel5.Image")));
            this.uiLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.Location = new System.Drawing.Point(531, 472);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(262, 40);
            this.uiLabel5.TabIndex = 17;
            this.uiLabel5.Text = "       Select Date";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Dashboard_Date
            // 
            this.txt_Dashboard_Date.FillColor = System.Drawing.Color.White;
            this.txt_Dashboard_Date.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_Dashboard_Date.Location = new System.Drawing.Point(536, 517);
            this.txt_Dashboard_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Dashboard_Date.MaxLength = 10;
            this.txt_Dashboard_Date.MinimumSize = new System.Drawing.Size(63, 0);
            this.txt_Dashboard_Date.Name = "txt_Dashboard_Date";
            this.txt_Dashboard_Date.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.txt_Dashboard_Date.Radius = 15;
            this.txt_Dashboard_Date.Size = new System.Drawing.Size(342, 34);
            this.txt_Dashboard_Date.SymbolDropDown = 61555;
            this.txt_Dashboard_Date.SymbolNormal = 61555;
            this.txt_Dashboard_Date.TabIndex = 18;
            this.txt_Dashboard_Date.Text = "2022-01-21";
            this.txt_Dashboard_Date.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Dashboard_Date.Value = new System.DateTime(2022, 1, 21, 19, 54, 48, 136);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel1.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel1.Image")));
            this.uiLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Location = new System.Drawing.Point(531, 261);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(366, 40);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "       Quantity";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1389, 698);
            this.Controls.Add(this.txt_Dashboard_Date);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.btn_Dashboard_Sell);
            this.Controls.Add(this.btn_Dashboard_Buy);
            this.Controls.Add(this.cb_Dashboard_Script);
            this.Controls.Add(this.cb_Dashboard_Client);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.txt_Dashboard_Price);
            this.Controls.Add(this.txt_Dashboard_Quantity);
            this.Controls.Add(this.uiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UC_Dashboard";
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox txt_Dashboard_Quantity;
        private Sunny.UI.UITextBox txt_Dashboard_Price;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIComboBox cb_Dashboard_Client;
        private Sunny.UI.UIComboBox cb_Dashboard_Script;
        private Sunny.UI.UIButton btn_Dashboard_Buy;
        private Sunny.UI.UIButton btn_Dashboard_Sell;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIDatePicker txt_Dashboard_Date;
        private Sunny.UI.UILabel uiLabel1;
    }
}
