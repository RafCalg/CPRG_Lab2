//Customer Bill program - Rafik Belhaouas 8/27/2019
//Handles the Customer Bill Form and allows new client to be added to a list
//Loads and displays a "customer.txt" file stored in the /bin/debug/ folder of the current directory
//Saves the newly added custyomer in the cutomers.txt files
//Displays the newly added customers in the listBox
// Uses Customer.cs Customer Class and Methods


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CustomerList;

namespace CPRG_Lab2
{
    public partial class CustomerBill : Form
    {
        //This is the customer List where all customer class objects are stored
        List<Customer> customerList = new List<Customer>();

        

        public CustomerBill()
        {
            InitializeComponent();
            customerTypeComboBox.SelectedIndex = 0;//sets the combo box to residential
            listBoxHeaders();
        }

        //On load read the Customers.txt file that is in the bin/debug subdirectory
        //transform each line of information into into a Customer object
        //save all the Customer objects in the customer.List
        //Display all the Customer objects in the customerListBox of the main form
        private void CustomerBill_Load(object sender, EventArgs e)
        {
            try
            {
                //the following finds the current bin/debug filepath and defines the file to load as Customers.txt 
                string filepath = string.Concat(Environment.CurrentDirectory, @"/Customers.txt");
                StreamReader input = new StreamReader(filepath);
                while (!input.EndOfStream)
                {
                    string linefromFile = input.ReadLine();
                    Customer c = new Customer(linefromFile);
                    addCustomer(c);
                }
                input.Close();
                statCalc(); //Calls the statCalc() method to calculate and display in the listbox a summary of the customers' bills 
            }
            catch (Exception excp)
            {
                MessageBox.Show($"Customer file did not load or has not been created yet.\n\n {excp.Message}");
            }
        }

        //This method is triggered when the calculateBill button is pressed to:
        // - add the new customer bill in the customer List 
        // - to calculate the bill
        // - to displaythe new customer in the listbox
        // - to save the Customers.txt file in bin/debug directory 
        private void calculateBillButton_Click(object sender, EventArgs e)
        {
            Customer c; // The customer object
            double usage = validUsage(usageTextBox.Text.Trim()); // the usage and peak usage in kwh 
            double offPeakUsage; // The off peak usage in kwh
            decimal calculatedCharge; //The calculated charge
            int custType = customerTypeComboBox.SelectedIndex; //selected Customer Type

            //based on the customer type - try if no valid exception thrown  to 
            // calculate the charge depnding on the usage 
            // and to save the data in a newly created Customer object added to the list 
            try
            {
                switch (custType)
                {
                    case 0: //Residential 
                        //usage = validUsage(usageTextBox.Text.Trim()); //Reads usage input and stores the value in usage 
                        calculatedCharge = Customer.CalculateCharge(custType, usage); //Calculates the charge
                        c = new Customer(int.Parse(accountNumberTextBox.Text.Trim()), //creates new Customer object with input data as properties
                                        customerNameTextBox.Text.Trim(),
                                        Customer.setCustomerType(customerTypeComboBox.SelectedItem.ToString()),
                                        calculatedCharge);
                        addCustomer(c);
                        break;
                    case 1: //Commercial
                        //usage = validUsage(usageTextBox.Text.Trim());
                        calculatedCharge = Customer.CalculateCharge(custType, usage);
                        c = new Customer(int.Parse(accountNumberTextBox.Text.Trim()),
                                        customerNameTextBox.Text.Trim(),
                                        Customer.setCustomerType(customerTypeComboBox.SelectedItem.ToString()),
                                        calculatedCharge);
                        addCustomer(c);
                        break;
                    case 2: //Industrial
                        //usage = validUsage(usageTextBox.Text.Trim());
                        offPeakUsage = validOffPeakUsage(offPeakUsageTextBox.Text.Trim());
                        calculatedCharge = Customer.CalculateCharge(usage, offPeakUsage);
                        c = new Customer(int.Parse(accountNumberTextBox.Text.Trim()),
                                        customerNameTextBox.Text.Trim(),
                                        Customer.setCustomerType(customerTypeComboBox.SelectedItem.ToString()),
                                        calculatedCharge);
                        addCustomer(c);
                        break;
                    default:
                        MessageBox.Show("Cannot create new Customer - Customer Type Not selected");
                        return;
                 }

                statCalc();

            }
            catch (ArgumentException excp)
            {
                MessageBox.Show($"Unable to create New Customer. Invalid Information.{excp.Message}");
                return;
            }
            catch (FormatException excp)
            {
                MessageBox.Show($"Unable to create New Product. Invalid Indformation.{excp.Message}");
                return;
            }



            try
            {
                string filepath = string.Concat(Environment.CurrentDirectory, @"/Customers.txt");
                StreamWriter output = new StreamWriter(filepath);
                foreach (Customer cust in customerList)
                {
                    output.WriteLine(cust.TofileString());
                }
                output.Close();

            }
            catch (Exception excp)
            {
                MessageBox.Show($"File did not write {excp.Message} ");
                return;
            }
            MessageBox.Show("Customer list has been saved in the bin/Debug/ subdirectory of this project as Customers.txt ");
        }
        //This method is used to add new customers to the list of Customers
        //and to display the new Customer in the List Box
        private void addCustomer(Customer c)
        {
            customerList.Add(c);
            customerListBox.Items.Add(c.ToFormattedString());
        }

        //This method calculates the required summary calculations in terms of
        //total counts and total charges
        private void statCalc()
        {
            int countResidential = 0;
            int countCommercial = 0;
            int countIndustrial = 0;
            int countTotal = 0;

            decimal chargeResidential = 0;
            decimal chargeCommercial = 0;
            decimal chargeIndustrial = 0;
            decimal chargeTotal = 0;

            //Loops through the customer list and calculate the summary variables
            //charge and count according to each type of customer
            foreach (Customer c in customerList)
            {
                switch (c.CustomerType)
                {
                    case 'R':
                        chargeResidential += c.ChargeAmount;
                        countResidential += 1;
                        break;
                    case 'C':
                        chargeCommercial += c.ChargeAmount;
                        countCommercial += 1;
                        break;
                    case 'I':
                        chargeIndustrial += c.ChargeAmount;
                        countIndustrial += 1;
                        break;
                    default:
                        MessageBox.Show("Statistics Calculation Failed");
                        break;
                }
                //calculates the total charge and count for all types of customers
                


            }

            //Calculates the total charge and total count
            chargeTotal = chargeResidential + chargeCommercial + chargeIndustrial;
            countTotal = countResidential + countCommercial + countIndustrial;
            
            //Assign the values to the Form text boxes
            totalCustomersTextBox.Text = countTotal.ToString();
            chargesResidentialTextBox.Text = chargeResidential.ToString("C");
            chargesCommercialTextBox.Text = chargeCommercial.ToString("C");
            chargesIndustrialTextBox.Text = chargeIndustrial.ToString("C");
            chargesAllCustomersTextBox.Text = chargeTotal.ToString("C");

        }

        //Method activated by the clear button to clear the input text fields 
        //and combo box selection
        private void clearAllButton_Click(object sender, EventArgs e)
        {
            //Loop through all the elements of the newBill Group Box
            //reset the Combobox and set the the text boxes to empty string  
            foreach (Control ctr in newBillGroupBox.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
                if (ctr is ComboBox)
                {
                    ctr.ResetText();
                }
            }
            customerTypeComboBox.SelectedIndex = 0;//sets the combo box to residential
        }

        //Changes the dislay and visible labels and text boxes 
        //depending on the customer type 
        private void customerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (customerTypeComboBox.SelectedIndex)
            {
                case 0:
                    usageLabel.Text = "Usage kwh";
                    offPeakUsageTextBox.Visible = false;
                    offPeakUsageLabel.Visible = false;
                    usageTextBox.Focus();
                    break;
                case 1:
                    usageLabel.Text = "Usage kwh";
                    offPeakUsageTextBox.Visible = false;
                    offPeakUsageLabel.Visible = false;
                    usageTextBox.Focus();
                    break;
                case 2:
                    usageLabel.Text = "Peak Usage";
                    offPeakUsageLabel.Visible = true;
                    offPeakUsageTextBox.Visible = true;
                    usageTextBox.Focus();
                    break;
            }
        }
        //Checks the validity of the usage or peak input - It needs to be positive numeric
        private double validUsage(string usage)
        {
            double validUsageInput;//usage value to be returned if usage is valid
            if (double.TryParse(usage, out validUsageInput))
            {
                if (validUsageInput >= 0.0D)
                {
                    return validUsageInput;
                }
                else
                {
                    usageTextBox.Focus();
                    throw new ArgumentException("Negative usage input");
                }
            }
            else
            {
                usageTextBox.Focus();
                throw new ArgumentException("Non numeric usage input");
            }
        }
        
        //Checks the validity of the off peak input - It needs to be positive numeric
        private double validOffPeakUsage(string usage)
        {
            double validUsageInput; //usage value to be returned if usage is valid
            if (double.TryParse(usage, out validUsageInput))
                if (validUsageInput >= 0.0D)
                {
                    return validUsageInput;
                }
                else
                {
                    usageTextBox.Focus();
                    throw new ArgumentException("Negative off Peak usage input");
                }
            else
            {
                usageTextBox.Focus();
                throw new ArgumentException("Non numeric off peak usage input");
            }
        }

        private void listBoxHeaders()
        {
            string theString = "";
            theString += $"{"Account No",-17}";               //A field of 10 characters is available " 
            theString += $"{"Customer Name",-23}";              //12 characters left justified
            theString += $"{"Type",-11}";               // 11 characters right justified
            theString += $"{"Amount",-15:C2}";           //15 characters and currency format 

            customerListBox.Items.Add(theString);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
