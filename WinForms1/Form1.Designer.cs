namespace WinForms1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtCustomerName = new TextBox();
            txtNumberOfPeople = new TextBox();
            txtLastMonthWaterMeter = new TextBox();
            form = new GroupBox();
            btnClear = new Button();
            lbThisMonthWaterMeter = new Label();
            lbNumberOfPeople = new Label();
            lbLastMonthWaterMeter = new Label();
            lbTypeOfCustomer = new Label();
            lbCustomerName = new Label();
            cboTypeOfCustomer = new ComboBox();
            btnCalculator = new Button();
            txtThisMonthWaterMeter = new TextBox();
            lvBill = new ListView();
            txtSearchWaterBill = new TextBox();
            lbSearch = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripMenuItem2 = new ToolStripMenuItem();
            ToolStripMenuItem3 = new ToolStripMenuItem();
            btnShowMenu = new Button();
            form.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(34, 69);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Enter customer name";
            txtCustomerName.Size = new Size(260, 31);
            txtCustomerName.TabIndex = 0;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // txtNumberOfPeople
            // 
            txtNumberOfPeople.Enabled = false;
            txtNumberOfPeople.Location = new Point(34, 195);
            txtNumberOfPeople.Name = "txtNumberOfPeople";
            txtNumberOfPeople.PlaceholderText = "Enter number of people";
            txtNumberOfPeople.Size = new Size(260, 31);
            txtNumberOfPeople.TabIndex = 2;
            // 
            // txtLastMonthWaterMeter
            // 
            txtLastMonthWaterMeter.Location = new Point(34, 257);
            txtLastMonthWaterMeter.Name = "txtLastMonthWaterMeter";
            txtLastMonthWaterMeter.PlaceholderText = "Enter last month water meter";
            txtLastMonthWaterMeter.Size = new Size(260, 31);
            txtLastMonthWaterMeter.TabIndex = 3;
            // 
            // form
            // 
            form.Controls.Add(btnClear);
            form.Controls.Add(lbThisMonthWaterMeter);
            form.Controls.Add(lbNumberOfPeople);
            form.Controls.Add(lbLastMonthWaterMeter);
            form.Controls.Add(lbTypeOfCustomer);
            form.Controls.Add(lbCustomerName);
            form.Controls.Add(cboTypeOfCustomer);
            form.Controls.Add(btnCalculator);
            form.Controls.Add(txtThisMonthWaterMeter);
            form.Controls.Add(txtCustomerName);
            form.Controls.Add(txtLastMonthWaterMeter);
            form.Controls.Add(txtNumberOfPeople);
            form.ForeColor = Color.FloralWhite;
            form.Location = new Point(12, 37);
            form.Name = "form";
            form.Size = new Size(352, 608);
            form.TabIndex = 4;
            form.TabStop = false;
            form.Text = "Form";
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(182, 378);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lbThisMonthWaterMeter
            // 
            lbThisMonthWaterMeter.AutoSize = true;
            lbThisMonthWaterMeter.Location = new Point(39, 291);
            lbThisMonthWaterMeter.Name = "lbThisMonthWaterMeter";
            lbThisMonthWaterMeter.Size = new Size(207, 25);
            lbThisMonthWaterMeter.TabIndex = 11;
            lbThisMonthWaterMeter.Text = "This Month Water Meter:";
            // 
            // lbNumberOfPeople
            // 
            lbNumberOfPeople.AutoSize = true;
            lbNumberOfPeople.Location = new Point(39, 167);
            lbNumberOfPeople.Name = "lbNumberOfPeople";
            lbNumberOfPeople.Size = new Size(164, 25);
            lbNumberOfPeople.TabIndex = 10;
            lbNumberOfPeople.Text = "Number Of People:";
            // 
            // lbLastMonthWaterMeter
            // 
            lbLastMonthWaterMeter.AutoSize = true;
            lbLastMonthWaterMeter.Location = new Point(39, 229);
            lbLastMonthWaterMeter.Name = "lbLastMonthWaterMeter";
            lbLastMonthWaterMeter.Size = new Size(207, 25);
            lbLastMonthWaterMeter.TabIndex = 9;
            lbLastMonthWaterMeter.Text = "Last Month Water Meter:";
            // 
            // lbTypeOfCustomer
            // 
            lbTypeOfCustomer.AutoSize = true;
            lbTypeOfCustomer.Location = new Point(39, 103);
            lbTypeOfCustomer.Name = "lbTypeOfCustomer";
            lbTypeOfCustomer.Size = new Size(160, 25);
            lbTypeOfCustomer.TabIndex = 8;
            lbTypeOfCustomer.Text = "Type Of Customer:";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new Point(39, 41);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(145, 25);
            lbCustomerName.TabIndex = 7;
            lbCustomerName.Text = "Customer Name:";
            // 
            // cboTypeOfCustomer
            // 
            cboTypeOfCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTypeOfCustomer.FormattingEnabled = true;
            cboTypeOfCustomer.Location = new Point(34, 131);
            cboTypeOfCustomer.Name = "cboTypeOfCustomer";
            cboTypeOfCustomer.Size = new Size(260, 33);
            cboTypeOfCustomer.TabIndex = 6;
            cboTypeOfCustomer.SelectedIndexChanged += cboTypeOfCustomer_SelectedIndexChanged;
            // 
            // btnCalculator
            // 
            btnCalculator.ForeColor = Color.Black;
            btnCalculator.Location = new Point(39, 378);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(112, 34);
            btnCalculator.TabIndex = 5;
            btnCalculator.Text = "Calculator";
            btnCalculator.UseVisualStyleBackColor = true;
            btnCalculator.Click += btnCalculator_Click;
            // 
            // txtThisMonthWaterMeter
            // 
            txtThisMonthWaterMeter.Location = new Point(34, 319);
            txtThisMonthWaterMeter.Name = "txtThisMonthWaterMeter";
            txtThisMonthWaterMeter.PlaceholderText = "Enter this month water meter";
            txtThisMonthWaterMeter.Size = new Size(260, 31);
            txtThisMonthWaterMeter.TabIndex = 4;
            // 
            // lvBill
            // 
            lvBill.FullRowSelect = true;
            lvBill.GridLines = true;
            lvBill.Location = new Point(370, 49);
            lvBill.Name = "lvBill";
            lvBill.Size = new Size(1007, 596);
            lvBill.TabIndex = 5;
            lvBill.UseCompatibleStateImageBehavior = false;
            lvBill.SelectedIndexChanged += lvBill_SelectedIndexChanged;
            // 
            // txtSearchWaterBill
            // 
            txtSearchWaterBill.Location = new Point(481, 12);
            txtSearchWaterBill.Name = "txtSearchWaterBill";
            txtSearchWaterBill.PlaceholderText = "Enter customer name";
            txtSearchWaterBill.Size = new Size(504, 31);
            txtSearchWaterBill.TabIndex = 6;
            txtSearchWaterBill.TextChanged += txtSearchWaterBill_TextChanged;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.ForeColor = Color.FloralWhite;
            lbSearch.Location = new Point(407, 15);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(68, 25);
            lbSearch.TabIndex = 7;
            lbSearch.Text = "Search:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem, ToolStripMenuItem1, ToolStripMenuItem2, ToolStripMenuItem3 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(188, 132);
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(187, 32);
            ToolStripMenuItem.Text = "Water used ↑";
            // 
            // ToolStripMenuItem1
            // 
            ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            ToolStripMenuItem1.Size = new Size(187, 32);
            ToolStripMenuItem1.Text = "Water used ↓";
            // 
            // ToolStripMenuItem2
            // 
            ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            ToolStripMenuItem2.Size = new Size(187, 32);
            ToolStripMenuItem2.Text = "Cost ↑";
            // 
            // ToolStripMenuItem3
            // 
            ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            ToolStripMenuItem3.Size = new Size(187, 32);
            ToolStripMenuItem3.Text = "Cost ↓";
            // 
            // btnShowMenu
            // 
            btnShowMenu.ContextMenuStrip = contextMenuStrip1;
            btnShowMenu.ForeColor = SystemColors.ActiveCaptionText;
            btnShowMenu.Location = new Point(1061, 10);
            btnShowMenu.Name = "btnShowMenu";
            btnShowMenu.Size = new Size(245, 34);
            btnShowMenu.TabIndex = 9;
            btnShowMenu.Text = "Sort";
            btnShowMenu.UseVisualStyleBackColor = true;
            btnShowMenu.MouseClick += btnShowMenu_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(1389, 716);
            Controls.Add(btnShowMenu);
            Controls.Add(lbSearch);
            Controls.Add(txtSearchWaterBill);
            Controls.Add(lvBill);
            Controls.Add(form);
            ForeColor = Color.Gold;
            Name = "Form1";
            Text = "App";
            Load += Form1_Load;
            form.ResumeLayout(false);
            form.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerName;
        private TextBox txtNumberOfPeople;
        private TextBox txtLastMonthWaterMeter;
        private GroupBox form;
        private TextBox txtThisMonthWaterMeter;
        private Button btnCalculator;
        private ComboBox cboTypeOfCustomer;
        private Label lbCustomerName;
        private Label lbThisMonthWaterMeter;
        private Label lbNumberOfPeople;
        private Label lbLastMonthWaterMeter;
        private Label lbTypeOfCustomer;
        private ListView lvBill;
        private Button btnClear;
        private TextBox txtSearchWaterBill;
        private Label lbSearch;
        private Button myButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItem1;
        private ToolStripMenuItem ToolStripMenuItem2;
        private ToolStripMenuItem ToolStripMenuItem3;
        private Button btnShowMenu;
    }
}
