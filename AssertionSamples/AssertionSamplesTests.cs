﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AssertionSamples
{
    [TestClass]
    public class AssertionSamplesTests
    {
        private readonly CustomerRepo _customerRepo = new CustomerRepo();

        [TestMethod]
        public void CompareCustomer()
        {
            var actual = _customerRepo.Get();

            //how to assert customer?
            Assert.Fail();
        }

        [TestMethod]
        public void CompareCustomerList()
        {
            var actual = _customerRepo.GetAll();

            //how to assert customers?
            Assert.Fail();
        }

        [TestMethod]
        public void CompareComposedCustomer()
        {
            var actual = _customerRepo.GetComposedCustomer();

            //how to assert composed customer?
            Assert.Fail();
        }

        /// <summary>
        /// Partials the compare customer birthday and order price.
        /// partial compare should use anonymous type
        /// </summary>
        [TestMethod]
        public void PartialCompare_Customer_Birthday_And_Order_Price()
        {
            var actual = _customerRepo.GetComposedCustomer();
            var expected = new Customer()
            {
                Birthday = new DateTime(1999, 9, 9),
                Order = new Order { Price = 91 },
            };

            //how to assert actual is equal to expected?
            Assert.Fail();
        }
    }

    public class CustomerRepo
    {
        public Customer Get()
        {
            return new Customer
            {
                Id = 2,
                Age = 18,
                Birthday = new DateTime(1990, 1, 26)
            };
        }

        public List<Customer> GetAll()
        {
            return new List<Customer>
            {
                new Customer()
                {
                    Id=3,
                    Age=20,
                    Birthday = new DateTime(1993,1,2)
                },

                new Customer()
                {
                    Id=4,
                    Age=21,
                    Birthday = new DateTime(1993,1,3)
                },
            };
        }

        public Customer GetComposedCustomer()
        {
            return new Customer()
            {
                Age = 30,
                Id = 11,
                Birthday = new DateTime(1999, 9, 9),
                Order = new Order { Id = 19, Price = 91 },
            };
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public int Price { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public Order Order { get; set; }
    }
}