using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Test
{
    public partial class Form1 : Form
    {
        public const double VAT = 0.1;
        private List<Invoice> invoices;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTypeOfCustomer.Items.Add("Household customer");
            cboTypeOfCustomer.Items.Add("Administrative agency, public services");
            cboTypeOfCustomer.Items.Add("Production units");
            cboTypeOfCustomer.Items.Add("Business services");

            lvWaterBill.View = View.Details;

            lvWaterBill.Columns.Add("Customer Name", 200);
            lvWaterBill.Columns.Add("Last Month Water Meter", 200);
            lvWaterBill.Columns.Add("This Month Water Meter", 200);
            lvWaterBill.Columns.Add("Amount Of Consumption", 200);
            lvWaterBill.Columns.Add("Total Water Bill", 200);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void cboTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerType = cboTypeOfCustomer.Text;
            if (customerType == "Household customer")
            {
                txtNumberOfPeople.Enabled = true;
            }
            else
            {
                txtNumberOfPeople.Enabled = false;
                txtNumberOfPeople.Text = "";
            }
        }

        private void btnCaculator_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();
            string customerType = cboTypeOfCustomer.Text;
            int numberOfPeople = 0;
            double lastMonthWaterMeter = 0;
            double thisMonthWaterMeter = 0;

            if (customerName == "")
            {
                MessageBox.Show("Please enter customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (customerType == "")
            {
                MessageBox.Show("Please enter customer type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (customerType == "Household customer")
            {
                if (!int.TryParse(txtNumberOfPeople.Text, out numberOfPeople) || numberOfPeople <= 0)
                {
                    MessageBox.Show("Please enter number of people.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!double.TryParse(txtLastMonthWaterMeter.Text, out lastMonthWaterMeter) || lastMonthWaterMeter < 0)
            {
                MessageBox.Show("Please enter last month's water meter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtThisMonthWaterMeter.Text, out thisMonthWaterMeter) || thisMonthWaterMeter < 0)
            {
                MessageBox.Show("Please enter this month's water meter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var waterBill = Calculator(customerType, numberOfPeople, lastMonthWaterMeter, thisMonthWaterMeter);
            ListViewItem item = new ListViewItem(customerName);
            item.SubItems.Add(lastMonthWaterMeter.ToString());
            item.SubItems.Add(thisMonthWaterMeter.ToString());
            item.SubItems.Add(waterBill.Item1.ToString());
            item.SubItems.Add(waterBill.Item2.ToString());
            lvWaterBill.Items.Add(item);

            Invoice invoice = new Invoice
            {
                CustomerName = customerName,
                LastMonthWaterMeter = lastMonthWaterMeter,
                ThisMonthWaterMeter = thisMonthWaterMeter,
                Consumption = waterBill.Item1,
                WaterMoney = waterBill.Item2
            };
            invoices.Add(invoice);  
        }
        private (double, double) Calculator(string customerType, int numberOfMember, double lastMonthWaterMeter, double thisMonthWaterMeter)
        {
            double consumption = thisMonthWaterMeter - lastMonthWaterMeter;
            double waterMoney = 0;



            if (customerType == "Household customer")
            {
                double avgConsumption = consumption / numberOfMember;

                if (avgConsumption < 10)
                {
                    waterMoney = avgConsumption * 5973 * numberOfMember;
                }
                else if (avgConsumption < 20) 
                {
                    waterMoney = (10 * 5973 * numberOfMember) +
                                 ((avgConsumption - 10) * 7052 * numberOfMember);
                }
                else if (avgConsumption < 30)
                {
                    waterMoney = (10 * 5973 * numberOfMember) +
                                 (10 * 7052 * numberOfMember) +
                                 ((avgConsumption - 20) * 8699 * numberOfMember);
                }
                else
                {
                    waterMoney = (10 * 5973 * numberOfMember) +
                                 (10 * 7052 * numberOfMember) +
                                 (10 * 8699 * numberOfMember) +
                                 ((avgConsumption - 30) * 15929 * numberOfMember);
                }
            }
            else if (customerType == "Administrative agency, public services")
            {
                waterMoney = consumption * 9955;
            }
            else if (customerType == "Production units")
            {
                waterMoney = consumption * 11615;
            }
            else if (customerType == "Business services")
            {
                waterMoney = consumption * 22068;
            }
            waterMoney += waterMoney * VAT;
            return (consumption, waterMoney);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            lvWaterBill.Items.Clear();
            bool foundResult = false;

            if (search == "")
            {
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());
                    lvWaterBill.Items.Add(item);
                }
                foundResult = true;
            }
            else
            {
                foreach (Invoice invoice in invoices)
                {
                    if (invoice.CustomerName == search)
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.WaterMoney.ToString());
                        lvWaterBill.Items.Add(item);
                        foundResult = true;
                    }
                }
            }
            if (!foundResult)
            {
                ListViewItem item = new ListViewItem("No results found.");
                lvWaterBill.Items.Add(item);
            }
        }

        private void lvWaterBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class Invoice
    {
        public string CustomerName { get; set; }
        public double LastMonthWaterMeter { get; set; }
        public double ThisMonthWaterMeter { get; set; }
        public double Consumption { get; set; }
        public double WaterMoney { get; set; }
    }
}
