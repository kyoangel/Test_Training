using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsolatedByInheritanceAndOverride;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsolatedByInheritanceAndOverride.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        /// <summary>
        /// Tests the synchronize book orders 3 orders only 2 book order.
        /// </summary>
        [TestMethod()]
        public void Test_SyncBookOrders_3_Orders_Only_2_book_order()
        {
            //Try to isolate dependency to unit test

            //var target = new OrderService();
            //target.SyncBookOrders();
            Assert.Fail();
        }
    }
}