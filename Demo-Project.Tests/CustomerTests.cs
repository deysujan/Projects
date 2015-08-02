using System;
using System.Collections.Generic;
using System.Linq;
using Demo_project.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo_Project.Tests
{
    [TestClass]
    public class CustomerTests
    {
        public List<Customer> TestCustomers
        {
            get
            {
                return new List<Customer>
                  {
                      new Customer{Name = "Test Person 1",Address = "Address-1"},
                       new Customer{Name = "Test Person 2",Address = "Address-2"}
                  };
            }
        }

        [TestMethod]
        public void CustomerAddressShouldBeCorrect()
        {
            Assert.AreEqual("Address-1", GetCustomerAddress("Test Person 1"));
            Assert.AreEqual("Address-2", GetCustomerAddress("Test Person 2"));
        }


        private string GetCustomerAddress(string customerName)
        {
            var customer = TestCustomers.FirstOrDefault(c => c.Name == customerName);
            if (customer != null)
                return customer.Address;

            return string.Empty;
        }
    }
}
