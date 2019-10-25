//Automatic testing of the Calculate Charge Method - Rafik Belhaouas 08/27/2019

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        // Check that valid numbers will result in a correct result for the Residential Category
        public void CalculateChargeTestResidentialValid() 
        {
            int custType = 0; //residential type customer
            double usage = 100; // usage is 100 kwh - Expected 11.2 bill
            decimal bill = Customer.CalculateCharge(custType, usage); 
                       
            Assert.AreEqual(11.2M, bill);   
        }

        [TestMethod()]
        // Check that invalid numbers will result in n exception
        
        public void CalculateChargeTestResidentialInvalid()
        {
            int custType = 3; //This corresponds to a fourth type of customer
            double usage = 500.0D;
            decimal bill = Customer.CalculateCharge(custType, usage);

            Assert.AreEqual(-1.0M, bill); //This is in the unlikely case that a 4 type of customer is introduced 
        }

        //*********************************************************************************

        [TestMethod()]
        // Check that valid numbers will result in a correct result for 
        //the Commercial Category where the usage is less than 1000 kwh
        public void CalculateChargeTestCommercialialValid1()
        {
            int custType = 1; //residential type customer
            double usage = 500; // usage is 500 kwh - Expected 60 bill
            decimal bill = Customer.CalculateCharge(custType, usage);

            Assert.AreEqual(60.0M, bill);
        }

        [TestMethod()]
        // Check that invalid numbers will result in a fail - 
        //This is just for demonstration as the regular fails are caught in a try and catch 
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateChargeTestCommercialFailed()
        {
            int custType = 1; //This corresponds to the Commercial type of customer
            double usage = -500; // Negative value for the usage should cause the method to fail
            decimal bill = Customer.CalculateCharge(custType, usage); //Expected bill is 69

            Assert.Fail();
           
        }
        //*******************************************************************************

        [TestMethod()]
        // Check that valid numbers will result in a correct result for 
        //the Industrial Category where the peak and off peak usage are both
        //less than 1000 kwh
        public void CalculateChargeTestIndustrialValid1()
        {
            double usage = 500; // both peak and off peak usage are below 1000 kwh
            double offPeakUsage = 500; 
            decimal bill = Customer.CalculateCharge(usage, offPeakUsage); //expected bill is 76

            Assert.AreEqual(116.0M, bill);
        }

        [TestMethod()]
        // Check that valid numbers will result in a correct result for 
        //the Industrial Category where the peak and off peak usage are both
        //more than 1000 kwh
        public void CalculateChargeTestIndustrialValid2()
        {
            double usage = 1200; // both peak and off peak usage are above 1000 kwh
            double offPeakUsage = 1200;
            decimal bill = Customer.CalculateCharge(usage, offPeakUsage); //expected bill is 134.6

            Assert.AreEqual(134.6M, bill);
        }
    }
}
