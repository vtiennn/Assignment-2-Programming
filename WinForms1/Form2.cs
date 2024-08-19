using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinForms1.Form1;

namespace WinForms1
{
    public partial class InvoiceWater : Form
    {
        public InvoiceWater(Invoice invoice)
        {
            InitializeComponent();
            lbCustomerName_Bill.Text = "Customer Name: " + invoice.CustomerName;
            lbTypeOfCustomer_Bill.Text = "Type Of Customer: " + invoice.TypeOfCustomer;
            lbLastMonthWaterMeter_Bill.Text = "Last Month Water Meter: " + invoice.LastMonthWaterMeter;
            lbThisMonthWaterMeter_Bill.Text = "This Month Water Meter: " + invoice.ThisMonthWaterMeter;
            lbWaterMoney_Bill.Text = "Water Usage Difference: " + invoice.WaterMoney;
            lbTotalCost_Bill.Text = "Total Cost: " + invoice.Consumption;

            this.Name = "InvoiceDetailForm";
            this.Text = "Invoice Detail";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
