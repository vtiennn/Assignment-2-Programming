using System.Windows.Forms;
using static WinForms1.Form1;

namespace WinForms1
{
    public partial class Form1 : Form
    {
        public List<Invoice> invoices = new List<Invoice>();
        public const decimal VAT = 0.1m;
        public Form1()
        {
            InitializeComponent();
            // Add an event handler for the KeyPress event of the txtNumberOfPeople textbox
            txtNumberOfPeople.KeyPress += new KeyPressEventHandler(txtNumberOfPeople_KeyPress);
            // Add an event handler for the KeyPress event of the txtLastMonthWaterMeter textbox
            txtLastMonthWaterMeter.KeyPress += new KeyPressEventHandler(txtLastMonthWaterMeter_KeyPress);
            // Add an event handler for the KeyPress event of the txtThisMonthWaterMeter textbox
            txtThisMonthWaterMeter.KeyPress += new KeyPressEventHandler(txtThisMonthWaterMeter_KeyPress);
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            // Get the customer name from the text box
            string customerName = txtCustomerName.Text;
            // Get the type of customer from the combo box
            string typeOfCustomer = cboTypeOfCustomer.Text;
            // Initialize the number of people to 0
            int numberOfPeople = 0;
            // Initialize the last month water meter to 0
            decimal lastMonthWaterMeter = 0;
            // Initialize the this month water meter to 0
            decimal thisMonthWaterMeter = 0;
            // Check if the customer name is empty
            if (string.IsNullOrEmpty(customerName))
            {
                // Show an error message if the customer name is empty
                MessageBox.Show("Please enter customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if the type of customer is empty
            if (string.IsNullOrEmpty(typeOfCustomer))
            {
                // Show an error message if the type of customer is empty
                MessageBox.Show("Please select type of customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if the type of customer is "Household customer"
            if (typeOfCustomer.Equals("Household customer"))
            {
                // Check if the number of people is a valid integer and not null
                if (!int.TryParse(txtNumberOfPeople.Text, out numberOfPeople) || numberOfPeople == null)
                {
                    // Show an error message if the number of people is not a valid integer or is null
                    MessageBox.Show("Please enter number of people.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtNumberOfPeople.Text, out numberOfPeople) || numberOfPeople < 1)
                {
                    // Show an error message if the number of people is not a valid integer or is less than 1
                    MessageBox.Show("Number of people must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // Check if the last month water meter is a valid decimal and not null
            if (!decimal.TryParse(txtLastMonthWaterMeter.Text, out lastMonthWaterMeter) || lastMonthWaterMeter == null)
            {
                // Show an error message if the last month water meter is not a valid decimal or is null
                MessageBox.Show("Please enter last month water meter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if the this month water meter is a valid decimal and not null
            if (!decimal.TryParse(txtThisMonthWaterMeter.Text, out thisMonthWaterMeter) || thisMonthWaterMeter == null)
            {
                // Show an error message if the this month water meter is not a valid decimal or is null
                MessageBox.Show("Please enter this month water meter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if the last month's water meter reading is greater than the this month's water meter reading
            if (!decimal.TryParse(txtLastMonthWaterMeter.Text, out lastMonthWaterMeter) && decimal.TryParse(txtThisMonthWaterMeter.Text, out thisMonthWaterMeter) || lastMonthWaterMeter > thisMonthWaterMeter)
            {
                // Show an error message if the last month's water meter reading is greater than the this month's water meter reading
                MessageBox.Show("Last month's water meter cannot be greater than this month's water meter! " + "Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Calculate the invoice based on the type of customer, number of people, last month's water meter reading, and this month's water meter reading
            var invoice = Calculator(typeOfCustomer, numberOfPeople, lastMonthWaterMeter, thisMonthWaterMeter);

            // Create a new ListViewItem with the customer's name
            ListViewItem item = new ListViewItem(customerName);
            // Add the last month's water meter reading to the ListViewItem
            item.SubItems.Add(lastMonthWaterMeter.ToString());
            // Add this month's water meter reading to the ListViewItem
            item.SubItems.Add(thisMonthWaterMeter.ToString());
            // Add the invoice amount to the ListViewItem
            item.SubItems.Add(invoice.Item1.ToString());
            // Add the invoice tax to the ListViewItem
            item.SubItems.Add(invoice.Item2.ToString());
            // Add the ListViewItem to the ListView
            lvBill.Items.Add(item);
            // Create a new Invoice object and assign values to its properties
            Invoice bill1 = new Invoice
            {
                // Assign the customer's name to the CustomerName property
                CustomerName = customerName,
                // Assign the current month's water meter reading to the ThisMonthWaterMeter property
                ThisMonthWaterMeter = thisMonthWaterMeter,
                // Assign the previous month's water meter reading to the LastMonthWaterMeter property
                LastMonthWaterMeter = lastMonthWaterMeter,
                // Assign the type of customer to the TypeOfCustomer property
                TypeOfCustomer = typeOfCustomer,
                // Assign the water money to the WaterMoney property
                WaterMoney = invoice.Item1,
                // Assign the consumption to the Consumption property
                Consumption = invoice.Item2,
            };
            // Add the new Invoice object to the invoices list
            invoices.Add(bill1);
        }



        private void cboTypeOfCustomer_TextChanged(object sender, EventArgs e)
        {
            // Get the selected type of customer
            string typeOfCustomer = cboTypeOfCustomer.Text;
            // If the selected type of customer is "Household customer"
            if (typeOfCustomer == "Household customer")
            {
                // Enable the number of people text box
                txtNumberOfPeople.Enabled = true;
            }
            else
            {
                // Disable the number of people text box
                txtNumberOfPeople.Enabled = false;
            }
        }

        private double CalculatorWater()
        {
            // This method is not used in the code
            return 0.0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add items to the type of customer combo box
            cboTypeOfCustomer.Items.Add("Household customer");
            cboTypeOfCustomer.Items.Add("Administration agency, public services");
            cboTypeOfCustomer.Items.Add("Production units");
            cboTypeOfCustomer.Items.Add("Business services");

            // Set the view of the bill list view to details
            lvBill.View = View.Details;
            // Add columns to the bill list view
            lvBill.Columns.Add("Customer Name", 150);
            lvBill.Columns.Add("Last Month Water Meter", 200);
            lvBill.Columns.Add("Last This Water Meter", 200);
            lvBill.Columns.Add("Amount Of Consumption", 200);
            lvBill.Columns.Add("Total Water Bill", 200);

        }

        private void cboTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected type of customer
            string typeOfCustomer = cboTypeOfCustomer.Text;
            // If the selected type of customer is "Household customer"
            if (typeOfCustomer.Equals("Household customer"))
            {
                // Enable the number of people text box
                txtNumberOfPeople.Enabled = true;
            }
            else
            {
                // Disable the number of people text box
                txtNumberOfPeople.Enabled = false;
                // Clear the text in the number of people text box
                txtNumberOfPeople.Text = "";
            }
        }
        private (decimal, decimal) Calculator(string typeOfCustomer, int numberOfPeople, decimal lastMonthWaterMeter, decimal thisMonthWaterMeter)
        {
            // Calculate the consumption and water money based on the type of customer
            decimal consumption = thisMonthWaterMeter - lastMonthWaterMeter;
            decimal waterMoney;
            if (typeOfCustomer.Equals("Household customer"))
            {
                decimal averageWaterUsed = consumption / numberOfPeople;
                waterMoney = BillWaterForHousehold(averageWaterUsed, consumption);
            }
            else if (typeOfCustomer.Equals("Administrative agency, public services"))
            {
                waterMoney = (consumption * 9955);
                waterMoney += (waterMoney * VAT);
            }
            else if (typeOfCustomer.Equals("Production units"))
            {
                waterMoney = (consumption * 11615);
                waterMoney += (waterMoney * VAT);
            }
            else
            {
                waterMoney = (consumption * 22068);
                waterMoney += (waterMoney * VAT);
            }
            return (consumption, waterMoney);
        }
        private decimal BillWaterForHousehold(decimal average, decimal consumption)
        {
            // Calculate the water money for a household customer
            decimal waterMoney = 0;
            if (average > 0 && average < 10)
            {
                waterMoney = (consumption * 5973);
                waterMoney += (waterMoney * VAT);
            }
            else if (average >= 10 && average < 20)
            {
                waterMoney = (consumption * 7052);
                waterMoney += (waterMoney * VAT);
            }
            else if (average >= 20 && average < 30)
            {
                waterMoney = (consumption * 8699);
                waterMoney += (waterMoney * VAT);
            }
            else
            {
                waterMoney = (consumption * 15929);
                waterMoney += (waterMoney * VAT);
            }
            return waterMoney;
        }
        private void ClearAllTextBoxes(Control control)
        {
            // Clear all text boxes in the form
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearAllTextBoxes(c);
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all text boxes in the form
            ClearAllTextBoxes(this);
        }
        private void txtNumberOfPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits and control characters in the number of people text box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtLastMonthWaterMeter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits, control characters and decimal points in the last month water meter text box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtThisMonthWaterMeter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits, control characters and decimal points in the this month water meter text box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchWaterBill_TextChanged(object sender, EventArgs e)
        {
            // Search for water bills based on the search text
            string searchText = txtSearchWaterBill.Text.ToLower().Trim();
            lvBill.Items.Clear();
            if (string.IsNullOrEmpty(searchText))
            {
                foreach (var invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());
                }
            }
            else
            {
                bool foundResult = false;
                foreach (var invoice in invoices)
                {
                    if (!string.IsNullOrEmpty(invoice.CustomerName) && invoice.CustomerName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.WaterMoney.ToString());
                        lvBill.Items.Add(item);
                        foundResult = true;
                    }
                }
                if (!foundResult)
                {
                    ListViewItem item = new ListViewItem("No result found!");
                    lvBill.Items.Add(item);
                }
            }
        }
        public class Invoice
        {
            // Define the invoice class
            public string CustomerName { get; set; }
            public string TypeOfCustomer { get; set; }
            public decimal LastMonthWaterMeter { get; set; }
            public decimal ThisMonthWaterMeter { get; set; }
            public decimal Consumption { get; set; }
            public decimal WaterMoney { get; set; }
        }
        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Open the invoice form when an item is selected in the bill list view
            if (lvBill.SelectedItems.Count > 0)
            {
                int billnew = lvBill.SelectedItems[0].Index;
                if (billnew >= 0 && billnew < invoices.Count)
                {
                    Invoice bill = invoices[billnew];
                    InvoiceWater form2 = new InvoiceWater(bill);
                    form2.ShowDialog();
                }
            }
        }



        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new list to store the sorted invoices
            List<Invoice> sortedInvoices = new List<Invoice>();
            // Sort the invoices in descending order by consumption and store them in the list
            sortedInvoices = invoices.OrderByDescending(i => i.Consumption).ToList();
            // Update the invoices list with the sorted invoices
            invoices = sortedInvoices;
            // Clear the items in the list view
            lvBill.Items.Clear();
            // Loop through the sorted invoices and add them to the list view
            foreach (var invoice in sortedInvoices)
            {
                ListViewItem item = new ListViewItem(invoice.CustomerName);
                item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                item.SubItems.Add(invoice.Consumption.ToString());
                item.SubItems.Add(invoice.WaterMoney.ToString());
                lvBill.Items.Add(item);
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Create a new list to store the sorted invoices
            List<Invoice> sortedInvoices = new List<Invoice>();
            // Sort the invoices in ascending order by consumption and store them in the list
            sortedInvoices = invoices.OrderBy(i => i.Consumption).ToList();
            // Update the invoices list with the sorted invoices
            invoices = sortedInvoices;
            // Clear the items in the list view
            lvBill.Items.Clear();
            // Loop through the sorted invoices and add them to the list view
            foreach (var invoice in sortedInvoices)
            {
                ListViewItem item = new ListViewItem(invoice.CustomerName);
                item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                item.SubItems.Add(invoice.Consumption.ToString());
                item.SubItems.Add(invoice.WaterMoney.ToString());
                lvBill.Items.Add(item);
            }
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Create a new list to store the sorted invoices
            List<Invoice> sortedInvoices = new List<Invoice>();
            // Sort the invoices in descending order by consumption and store them in the list
            sortedInvoices = invoices.OrderByDescending(i => i.Consumption).ToList();
            // Update the invoices list with the sorted invoices
            invoices = sortedInvoices;
            // Clear the items in the list view
            lvBill.Items.Clear();
            // Loop through the sorted invoices and add them to the list view
            foreach (var invoice in sortedInvoices)
            {
                ListViewItem item = new ListViewItem(invoice.CustomerName);
                item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                item.SubItems.Add(invoice.Consumption.ToString());
                item.SubItems.Add(invoice.WaterMoney.ToString());
                lvBill.Items.Add(item);
            }
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Create a new list to store the sorted invoices
            List<Invoice> sortedInvoices = new List<Invoice>();
            // Sort the invoices in ascending order by consumption and store them in the list
            sortedInvoices = invoices.OrderBy(i => i.Consumption).ToList();
            // Update the invoices list with the sorted invoices
            invoices = sortedInvoices;
            // Clear the items in the list view
            lvBill.Items.Clear();
            // Loop through the sorted invoices and add them to the list view
            foreach (var invoice in sortedInvoices)
            {
                ListViewItem item = new ListViewItem(invoice.CustomerName);
                item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                item.SubItems.Add(invoice.Consumption.ToString());
                item.SubItems.Add(invoice.WaterMoney.ToString());
                lvBill.Items.Add(item);
            }
        }

        private void btnShowMenu_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the button that triggered the event
            Button btnSender = (Button)sender;
            // Get the point at the lower left of the button
            Point ptLowerLeft = new Point(0, btnSender.Height);
            // Convert the point to screen coordinates
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            // Show the context menu at the point
            contextMenuStrip1.Show(ptLowerLeft);
        }
    }
}
