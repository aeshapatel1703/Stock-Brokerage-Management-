namespace BBA_Software.User_control
{
    partial class UC_Stocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Stocks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_Stocks_Client = new Sunny.UI.UIComboBox();
            this.txt_Dashboard_SDate = new Sunny.UI.UIDatePicker();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ScriptGridView = new Sunny.UI.UIDataGridView();
            this.btn_View = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txt_Dashboard_EDate = new Sunny.UI.UIDatePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Stocks_Client
            // 
            this.cb_Stocks_Client.DataSource = null;
            this.cb_Stocks_Client.FillColor = System.Drawing.Color.White;
            this.cb_Stocks_Client.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cb_Stocks_Client.Location = new System.Drawing.Point(30, 127);
            this.cb_Stocks_Client.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Stocks_Client.MinimumSize = new System.Drawing.Size(63, 0);
            this.cb_Stocks_Client.Name = "cb_Stocks_Client";
            this.cb_Stocks_Client.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cb_Stocks_Client.Radius = 15;
            this.cb_Stocks_Client.Size = new System.Drawing.Size(342, 34);
            this.cb_Stocks_Client.TabIndex = 14;
            this.cb_Stocks_Client.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_Stocks_Client.Watermark = "Choose Client";
            // 
            // txt_Dashboard_SDate
            // 
            this.txt_Dashboard_SDate.FillColor = System.Drawing.Color.White;
            this.txt_Dashboard_SDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_Dashboard_SDate.Location = new System.Drawing.Point(30, 284);
            this.txt_Dashboard_SDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Dashboard_SDate.MaxLength = 10;
            this.txt_Dashboard_SDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.txt_Dashboard_SDate.Name = "txt_Dashboard_SDate";
            this.txt_Dashboard_SDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.txt_Dashboard_SDate.Radius = 15;
            this.txt_Dashboard_SDate.Size = new System.Drawing.Size(342, 34);
            this.txt_Dashboard_SDate.SymbolDropDown = 61555;
            this.txt_Dashboard_SDate.SymbolNormal = 61555;
            this.txt_Dashboard_SDate.TabIndex = 19;
            this.txt_Dashboard_SDate.Text = "2022-01-21";
            this.txt_Dashboard_SDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Dashboard_SDate.Value = new System.DateTime(2022, 1, 21, 19, 54, 48, 136);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel3.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel3.Image")));
            this.uiLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.Location = new System.Drawing.Point(25, 82);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(332, 40);
            this.uiLabel3.TabIndex = 12;
            this.uiLabel3.Text = "       Select Client";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel5.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel5.Image")));
            this.uiLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.Location = new System.Drawing.Point(25, 239);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(262, 40);
            this.uiLabel5.TabIndex = 20;
            this.uiLabel5.Text = "       Starting Date";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.ScriptGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(468, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 698);
            this.panel1.TabIndex = 21;
            // 
            // ScriptGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ScriptGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ScriptGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScriptGridView.BackgroundColor = System.Drawing.Color.White;
            this.ScriptGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ScriptGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ScriptGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ScriptGridView.ColumnHeadersHeight = 70;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ScriptGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ScriptGridView.EnableHeadersVisualStyles = false;
            this.ScriptGridView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ScriptGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.ScriptGridView.Location = new System.Drawing.Point(15, 21);
            this.ScriptGridView.Name = "ScriptGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ScriptGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ScriptGridView.RowHeadersVisible = false;
            this.ScriptGridView.RowHeadersWidth = 51;
            this.ScriptGridView.RowHeight = 24;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.ScriptGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ScriptGridView.RowTemplate.DividerHeight = 3;
            this.ScriptGridView.RowTemplate.Height = 24;
            this.ScriptGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ScriptGridView.SelectedIndex = -1;
            this.ScriptGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ScriptGridView.Size = new System.Drawing.Size(891, 642);
            this.ScriptGridView.StripeOddColor = System.Drawing.Color.White;
            this.ScriptGridView.TabIndex = 0;
            // 
            // btn_View
            // 
            this.btn_View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.Location = new System.Drawing.Point(83, 516);
            this.btn_View.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_View.Name = "btn_View";
            this.btn_View.Radius = 15;
            this.btn_View.Size = new System.Drawing.Size(217, 50);
            this.btn_View.Style = Sunny.UI.UIStyle.Custom;
            this.btn_View.TabIndex = 22;
            this.btn_View.Text = "VIEW DETAILS";
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel1.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel1.Image")));
            this.uiLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Location = new System.Drawing.Point(25, 365);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(262, 40);
            this.uiLabel1.TabIndex = 23;
            this.uiLabel1.Text = "       Ending Date";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Dashboard_EDate
            // 
            this.txt_Dashboard_EDate.FillColor = System.Drawing.Color.White;
            this.txt_Dashboard_EDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_Dashboard_EDate.Location = new System.Drawing.Point(30, 410);
            this.txt_Dashboard_EDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Dashboard_EDate.MaxLength = 10;
            this.txt_Dashboard_EDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.txt_Dashboard_EDate.Name = "txt_Dashboard_EDate";
            this.txt_Dashboard_EDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.txt_Dashboard_EDate.Radius = 15;
            this.txt_Dashboard_EDate.Size = new System.Drawing.Size(342, 34);
            this.txt_Dashboard_EDate.SymbolDropDown = 61555;
            this.txt_Dashboard_EDate.SymbolNormal = 61555;
            this.txt_Dashboard_EDate.TabIndex = 24;
            this.txt_Dashboard_EDate.Text = "2022-01-21";
            this.txt_Dashboard_EDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Dashboard_EDate.Value = new System.DateTime(2022, 1, 21, 19, 54, 48, 136);
            // 
            // UC_Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1389, 698);
            this.Controls.Add(this.txt_Dashboard_EDate);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.txt_Dashboard_SDate);
            this.Controls.Add(this.cb_Stocks_Client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UC_Stocks";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScriptGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIComboBox cb_Stocks_Client;
        private Sunny.UI.UIDatePicker txt_Dashboard_SDate;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel5;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIDataGridView ScriptGridView;
        private Sunny.UI.UIButton btn_View;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDatePicker txt_Dashboard_EDate;
    }
}
