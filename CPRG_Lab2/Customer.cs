//Creates Customer Class and associated Method - Rafik Belhaouas 08/27/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList
{
    public class Customer
    {
        public int AccountNo // The Public Account Number variable used to access the class
        {
            get
            {
                return accountNo; // the get method returns the private value of the Account Number
            }
        }

        public string CustomerName //The Public Customer Name variable used to access the class
        {
            get
            {
                return customerName; // the get method returns the private value of the Customer Number
            }
        }
        public char CustomerType  //The Customer Type variable used to access the class
        {
            get
            {
                return customerType; // the get method returns the private value of the customer Type "R" "C" or "I"
            }
            set
            {
                customerType = value; // There is no validation yet - Not sure this one needs a set
            }
        }

        public decimal ChargeAmount //The Charge Amount variable used to access the class
        {
            get
            {
                return chargeAmount; // the get method returns the private charge amount value
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Negative Cost"); // in case the user tries to set the charge Amount to negative or zero, the system throws an exception
                }
                chargeAmount = value; // if the value is not negative then it is passed to the private chargeAmount
            }
        }

        // PRIVATE SHADOW properties
        private int accountNo;
        private string customerName;
        private char customerType;
        private decimal chargeAmount;

        //Constructors  

        public Customer(string fromFile)
        {
            char[] delimiters = { '|', ',' };
            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            accountNo = int.Parse(tokens[0]);
            customerName = tokens[1];
            customerType = char.Parse(tokens[2]);
            chargeAmount = decimal.Parse(tokens[3]);
        }

        public string TofileString()
        {
            string theString = "";
            theString += $"{ accountNo}|"; // Use of | as separator

            theString += $"{customerName}|";
            theString += $"{customerType}|";
            theString += $"{chargeAmount}"; //last element will not need a separator

            return theString;
        }

        public Customer(int account, string customer, char custType, decimal amount)
        {
            if (!(validateAccountNo(account)))
                throw new ArgumentException("Account Number Not Valid");
            if (!(validateCustomer(customer)))
                throw new ArgumentException("Customer Name should not be empty");
            if (!(validateCustomerType(custType)))
                throw new ArgumentException("Customer Type should not be empty");
            

            accountNo = account;
            customerName = customer;
            customerType = custType; // customerType is a character - The combo box selection returns a string - The setCustomerType makes the transformation
            chargeAmount = amount; // The amount is the result of a calculation it should not need to be validated - Probably need a method here
        }

        public static char setCustomerType(string custType)
        {
            if (custType == "Residential")
            {
                return 'R';
            }
            else if (custType == "Commercial")
            {
                return 'C';
            }
            else if (custType == "Industrial")
            {
                return 'I';
            }
            else
            {
                throw new ArgumentException("Could not determine CustomerType");
            }
        }



        public Customer(int account, string customer, char type)
        {
            accountNo = account;
            customerName = customer;
            customerType = type;
        }

        public static decimal CalculateCharge(int type, double kwh)
        {
            decimal bill;
            switch (type)
            {
                case 0:
                    bill = 6.0M + Convert.ToDecimal(0.052 * kwh);
                    return bill;
                case 1:
                    if (kwh <= 1000.0D && kwh >= 0)
                    {
                        bill = 60.0M;
                    }
                    else if (kwh <0)
                    {
                        throw new ArgumentException("Invalid input- Negative usage value"); 
                    }
                    else
                    {
                        bill = 60.0M + Convert.ToDecimal((kwh - 1000.0)) * 0.045M;
                    }
                    return bill;
                default:
                    bill = -1;
                    return bill;
            }
        }
            
        
        public static decimal CalculateCharge(double kwh,double kwhOff) // Still need to work on this one - This one is overridden in all three classes
        {
            decimal billPeak;
            decimal billOffPeak;
            decimal bill;
            if (kwh <= 1000.0D && kwhOff <= 1000.0D)
            {
                billPeak = 76.0M;
                billOffPeak = 40.0M;
                bill = billPeak + billOffPeak;
                return bill;
            }
            else if (kwh > 1000 && kwhOff <= 1000.0D)
            {
                billPeak = 76.0M + Convert.ToDecimal((kwh - 1000.0)) * 0.065M;
                billOffPeak = 40.0M;
                bill = billPeak + billOffPeak;
                return bill;
            }
            else if (kwh > 1000 && kwhOff > 1000.0D)
            {
                billPeak = 76.0M + Convert.ToDecimal(kwh - 1000.0) * 0.065M;
                billOffPeak = 40.0M + Convert.ToDecimal(kwhOff - 1000.0) * 0.028M;
                bill = billPeak + billOffPeak;
                return bill;
            }
            else if (kwh <= 1000 && kwhOff > 1000.0D)
            {
                billPeak = 76.0M;
                billOffPeak = 40.0M + Convert.ToDecimal(kwhOff - 1000.0) * 0.028M;
                bill = billPeak + billOffPeak;
                return bill;
            }
            else
            {
                bill = -1.0M;
                return bill;
            }
            
        }

        public override string ToString() // ToString method to display object data
        {
            return $"Account Number: '{AccountNo}' Customer Name: {CustomerName} Customer Type: {CustomerType} Charge Amount: {ChargeAmount} ";
        }

        public string ToFormattedString() //A formatted version of the ToString method
        {
            string theString = "";
            theString += $"{accountNo,-17}";               //A field of 10 characters is available " 
            theString += $"{customerName,-23}";              //12 characters left justified
            theString += $"{customerType,-11}";               // 11 characters right justified
            theString += $"{chargeAmount, -15:C2}";           //15 characters and currency format 

            return theString;
        }


        //Validate Account Number
        private bool validateAccountNo(long accountNo)
        {
            if (!((accountNo >= 100000) && (accountNo <= 9999999999)))
                return false;
            else
                return true;
        }

        //Validate Customer name and sees if it is empty
        private bool validateCustomer(string customer)
        {
            if (customer != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Validate customer Type
        private bool validateCustomerType(char custType)
        {
            if ((custType != 'R') | (custType != 'C')| (custType != 'I'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
