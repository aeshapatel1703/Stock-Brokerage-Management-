namespace BBA_Software.User_control
{
    partial class UC_Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Clients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btn_delete_client = new Sunny.UI.UIButton();
            this.btn_update_client = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txt_Clients_brokerage = new Sunny.UI.UITextBox();
            this.txt_Clients_state = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.txt_Clients_address = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txt_Clients_mobile = new Sunny.UI.UITextBox();
            this.txt_Clients_name = new Sunny.UI.UITextBox();
            this.btn_Client_Add = new Sunny.UI.UIButton();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Controls.Add(this.btn_delete_client);
            this.panel1.Controls.Add(this.btn_update_client);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Controls.Add(this.txt_Clients_brokerage);
            this.panel1.Controls.Add(this.txt_Clients_state);
            this.panel1.Controls.Add(this.uiLabel7);
            this.panel1.Controls.Add(this.uiLabel6);
            this.panel1.Controls.Add(this.txt_Clients_address);
            this.panel1.Controls.Add(this.uiLabel4);
            this.panel1.Controls.Add(this.txt_Clients_mobile);
            this.panel1.Controls.Add(this.txt_Clients_name);
            this.panel1.Controls.Add(this.btn_Client_Add);
            this.panel1.Controls.Add(this.uiDataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 698);
            this.panel1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(87, 111);
            this.comboBox1.MaxDropDownItems = 10;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(342, 24);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel2.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel2.Image")));
            this.uiLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.Location = new System.Drawing.Point(82, 68);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(366, 40);
            this.uiLabel2.TabIndex = 32;
            this.uiLabel2.Text = "       Client ID";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_delete_client
            // 
            this.btn_delete_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_client.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.btn_delete_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_client.Location = new System.Drawing.Point(1129, 610);
            this.btn_delete_client.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_delete_client.Name = "btn_delete_client";
            this.btn_delete_client.Radius = 15;
            this.btn_delete_client.Size = new System.Drawing.Size(188, 50);
            this.btn_delete_client.Style = Sunny.UI.UIStyle.Custom;
            this.btn_delete_client.TabIndex = 31;
            this.btn_delete_client.Text = "Delete Client";
            this.btn_delete_client.Click += new System.EventHandler(this.btn_delete_client_Click_1);
            // 
            // btn_update_client
            // 
            this.btn_update_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_client.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.btn_update_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_client.Location = new System.Drawing.Point(851, 610);
            this.btn_update_client.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_update_client.Name = "btn_update_client";
            this.btn_update_client.Radius = 15;
            this.btn_update_client.Size = new System.Drawing.Size(188, 50);
            this.btn_update_client.Style = Sunny.UI.UIStyle.Custom;
            this.btn_update_client.TabIndex = 30;
            this.btn_update_client.Text = "Update Client";
            this.btn_update_client.Click += new System.EventHandler(this.btn_update_client_Click_1);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel1.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel1.Image")));
            this.uiLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Location = new System.Drawing.Point(82, 254);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(366, 40);
            this.uiLabel1.TabIndex = 29;
            this.uiLabel1.Text = "       Client Mobile";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel3.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel3.Image")));
            this.uiLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.Location = new System.Drawing.Point(82, 160);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(366, 40);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "       Client Name";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Clients_brokerage
            // 
            this.txt_Clients_brokerage.ButtonSymbol = 61761;
            this.txt_Clients_brokerage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Clients_brokerage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txt_Clients_brokerage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Clients_brokerage.Location = new System.Drawing.Point(87, 603);
            this.txt_Clients_brokerage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Clients_brokerage.Maximum = 2147483647D;
            this.txt_Clients_brokerage.Minimum = -2147483648D;
            this.txt_Clients_brokerage.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Clients_brokerage.Name = "txt_Clients_brokerage";
            this.txt_Clients_brokerage.Radius = 15;
            this.txt_Clients_brokerage.Size = new System.Drawing.Size(342, 34);
            this.txt_Clients_brokerage.Style = Sunny.UI.UIStyle.Custom;
            this.txt_Clients_brokerage.TabIndex = 28;
            this.txt_Clients_brokerage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Clients_brokerage.Watermark = "Enter Brokerage";
            this.txt_Clients_brokerage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Clients_brokerage_KeyPress);
            // 
            // txt_Clients_state
            // 
            this.txt_Clients_state.ButtonSymbol = 61761;
            this.txt_Clients_state.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Clients_state.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txt_Clients_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Clients_state.Location = new System.Drawing.Point(87, 505);
            this.txt_Clients_state.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Clients_state.Maximum = 2147483647D;
            this.txt_Clients_state.Minimum = -2147483648D;
            this.txt_Clients_state.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Clients_state.Name = "txt_Clients_state";
            this.txt_Clients_state.Radius = 15;
            this.txt_Clients_state.Size = new System.Drawing.Size(342, 34);
            this.txt_Clients_state.Style = Sunny.UI.UIStyle.Custom;
            this.txt_Clients_state.TabIndex = 27;
            this.txt_Clients_state.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Clients_state.Watermark = "Enter State";
            this.txt_Clients_state.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Clients_state_KeyPress);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel7.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel7.Image")));
            this.uiLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel7.Location = new System.Drawing.Point(82, 558);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(332, 40);
            this.uiLabel7.TabIndex = 26;
            this.uiLabel7.Text = "       Client Brokerage i.e.0.0002";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel6.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel6.Image")));
            this.uiLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.Location = new System.Drawing.Point(82, 460);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(332, 40);
            this.uiLabel6.TabIndex = 25;
            this.uiLabel6.Text = "       State";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Clients_address
            // 
            this.txt_Clients_address.ButtonSymbol = 61761;
            this.txt_Clients_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Clients_address.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txt_Clients_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Clients_address.Location = new System.Drawing.Point(85, 403);
            this.txt_Clients_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Clients_address.Maximum = 2147483647D;
            this.txt_Clients_address.Minimum = -2147483648D;
            this.txt_Clients_address.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Clients_address.Name = "txt_Clients_address";
            this.txt_Clients_address.Radius = 15;
            this.txt_Clients_address.Size = new System.Drawing.Size(342, 34);
            this.txt_Clients_address.Style = Sunny.UI.UIStyle.Custom;
            this.txt_Clients_address.TabIndex = 22;
            this.txt_Clients_address.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Clients_address.Watermark = "Enter Address";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.uiLabel4.Image = ((System.Drawing.Image)(resources.GetObject("uiLabel4.Image")));
            this.uiLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.Location = new System.Drawing.Point(82, 358);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(332, 40);
            this.uiLabel4.TabIndex = 22;
            this.uiLabel4.Text = "       Address";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Clients_mobile
            // 
            this.txt_Clients_mobile.ButtonSymbol = 61761;
            this.txt_Clients_mobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Clients_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Clients_mobile.Location = new System.Drawing.Point(87, 299);
            this.txt_Clients_mobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Clients_mobile.Maximum = 2147483647D;
            this.txt_Clients_mobile.MaxLength = 10;
            this.txt_Clients_mobile.Minimum = -2147483648D;
            this.txt_Clients_mobile.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Clients_mobile.Name = "txt_Clients_mobile";
            this.txt_Clients_mobile.Radius = 15;
            this.txt_Clients_mobile.Size = new System.Drawing.Size(342, 34);
            this.txt_Clients_mobile.TabIndex = 20;
            this.txt_Clients_mobile.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Clients_mobile.Watermark = "Enter Mobile Number";
            this.txt_Clients_mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Clients_mobile_KeyPress);
            // 
            // txt_Clients_name
            // 
            this.txt_Clients_name.ButtonSymbol = 61761;
            this.txt_Clients_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Clients_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Clients_name.Location = new System.Drawing.Point(87, 205);
            this.txt_Clients_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Clients_name.Maximum = 2147483647D;
            this.txt_Clients_name.Minimum = -2147483648D;
            this.txt_Clients_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Clients_name.Name = "txt_Clients_name";
            this.txt_Clients_name.Radius = 15;
            this.txt_Clients_name.Size = new System.Drawing.Size(342, 34);
            this.txt_Clients_name.TabIndex = 18;
            this.txt_Clients_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Clients_name.Watermark = "Enter Name";
            this.txt_Clients_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Clients_name_KeyPress);
            // 
            // btn_Client_Add
            // 
            this.btn_Client_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Client_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.btn_Client_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Client_Add.Location = new System.Drawing.Point(583, 610);
            this.btn_Client_Add.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Client_Add.Name = "btn_Client_Add";
            this.btn_Client_Add.Radius = 15;
            this.btn_Client_Add.Size = new System.Drawing.Size(188, 50);
            this.btn_Client_Add.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Client_Add.TabIndex = 16;
            this.btn_Client_Add.Text = "Add Client";
            this.btn_Client_Add.Click += new System.EventHandler(this.btn_Client_Add_Click);
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.uiDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.uiDataGridView1.ColumnHeadersHeight = 60;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle33;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.uiDataGridView1.Location = new System.Drawing.Point(454, 21);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.uiDataGridView1.RowHeadersVisible = false;
            this.uiDataGridView1.RowHeadersWidth = 51;
            this.uiDataGridView1.RowHeight = 24;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.uiDataGridView1.RowTemplate.DividerHeight = 3;
            this.uiDataGridView1.RowTemplate.Height = 24;
            this.uiDataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiDataGridView1.Size = new System.Drawing.Size(922, 552);
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.White;
            this.uiDataGridView1.TabIndex = 0;
            // 
            // UC_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1389, 698);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UC_Clients";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIButton btn_Client_Add;
        private Sunny.UI.UITextBox txt_Clients_name;
        private Sunny.UI.UITextBox txt_Clients_mobile;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txt_Clients_address;
        private Sunny.UI.UITextBox txt_Clients_brokerage;
        private Sunny.UI.UITextBox txt_Clients_state;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btn_delete_client;
        private Sunny.UI.UIButton btn_update_client;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
