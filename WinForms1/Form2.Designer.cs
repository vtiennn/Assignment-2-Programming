namespace WinForms1
{
    partial class InvoiceWater
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
            lbBill = new Label();
            lbCustomerName_Bill = new Label();
            lbTypeOfCustomer_Bill = new Label();
            lbLastMonthWaterMeter_Bill = new Label();
            lbThisMonthWaterMeter_Bill = new Label();
            lbWaterMoney_Bill = new Label();
            lbTotalCost_Bill = new Label();
            SuspendLayout();
            // 
            // lbBill
            // 
            lbBill.AutoSize = true;
            lbBill.ForeColor = Color.FloralWhite;
            lbBill.Location = new Point(155, 34);
            lbBill.Name = "lbBill";
            lbBill.Size = new Size(205, 25);
            lbBill.TabIndex = 1;
            lbBill.Text = "INVOICE INFORMATION";
            // 
            // lbCustomerName_Bill
            // 
            lbCustomerName_Bill.AutoSize = true;
            lbCustomerName_Bill.ForeColor = Color.FloralWhite;
            lbCustomerName_Bill.Location = new Point(62, 63);
            lbCustomerName_Bill.Name = "lbCustomerName_Bill";
            lbCustomerName_Bill.Size = new Size(59, 25);
            lbCustomerName_Bill.TabIndex = 2;
            lbCustomerName_Bill.Text = "label2";
            lbCustomerName_Bill.Click += label2_Click;
            // 
            // lbTypeOfCustomer_Bill
            // 
            lbTypeOfCustomer_Bill.AutoSize = true;
            lbTypeOfCustomer_Bill.ForeColor = Color.FloralWhite;
            lbTypeOfCustomer_Bill.Location = new Point(62, 98);
            lbTypeOfCustomer_Bill.Name = "lbTypeOfCustomer_Bill";
            lbTypeOfCustomer_Bill.Size = new Size(59, 25);
            lbTypeOfCustomer_Bill.TabIndex = 3;
            lbTypeOfCustomer_Bill.Text = "label3";
            // 
            // lbLastMonthWaterMeter_Bill
            // 
            lbLastMonthWaterMeter_Bill.AutoSize = true;
            lbLastMonthWaterMeter_Bill.ForeColor = Color.FloralWhite;
            lbLastMonthWaterMeter_Bill.Location = new Point(62, 133);
            lbLastMonthWaterMeter_Bill.Name = "lbLastMonthWaterMeter_Bill";
            lbLastMonthWaterMeter_Bill.Size = new Size(59, 25);
            lbLastMonthWaterMeter_Bill.TabIndex = 4;
            lbLastMonthWaterMeter_Bill.Text = "label4";
            // 
            // lbThisMonthWaterMeter_Bill
            // 
            lbThisMonthWaterMeter_Bill.AutoSize = true;
            lbThisMonthWaterMeter_Bill.ForeColor = Color.FloralWhite;
            lbThisMonthWaterMeter_Bill.Location = new Point(62, 167);
            lbThisMonthWaterMeter_Bill.Name = "lbThisMonthWaterMeter_Bill";
            lbThisMonthWaterMeter_Bill.Size = new Size(59, 25);
            lbThisMonthWaterMeter_Bill.TabIndex = 5;
            lbThisMonthWaterMeter_Bill.Text = "label5";
            // 
            // lbWaterMoney_Bill
            // 
            lbWaterMoney_Bill.AutoSize = true;
            lbWaterMoney_Bill.ForeColor = Color.FloralWhite;
            lbWaterMoney_Bill.Location = new Point(62, 203);
            lbWaterMoney_Bill.Name = "lbWaterMoney_Bill";
            lbWaterMoney_Bill.Size = new Size(59, 25);
            lbWaterMoney_Bill.TabIndex = 6;
            lbWaterMoney_Bill.Text = "label6";
            // 
            // lbTotalCost_Bill
            // 
            lbTotalCost_Bill.AutoSize = true;
            lbTotalCost_Bill.ForeColor = Color.FloralWhite;
            lbTotalCost_Bill.Location = new Point(62, 238);
            lbTotalCost_Bill.Name = "lbTotalCost_Bill";
            lbTotalCost_Bill.Size = new Size(59, 25);
            lbTotalCost_Bill.TabIndex = 7;
            lbTotalCost_Bill.Text = "label7";
            // 
            // InvoiceWater
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(523, 320);
            Controls.Add(lbTotalCost_Bill);
            Controls.Add(lbWaterMoney_Bill);
            Controls.Add(lbThisMonthWaterMeter_Bill);
            Controls.Add(lbLastMonthWaterMeter_Bill);
            Controls.Add(lbTypeOfCustomer_Bill);
            Controls.Add(lbCustomerName_Bill);
            Controls.Add(lbBill);
            ForeColor = SystemColors.ControlLightLight;
            Name = "InvoiceWater";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbBill;
        private Label lbCustomerName_Bill;
        private Label lbTypeOfCustomer_Bill;
        private Label lbLastMonthWaterMeter_Bill;
        private Label lbThisMonthWaterMeter_Bill;
        private Label lbWaterMoney_Bill;
        private Label lbTotalCost_Bill;
    }
}