using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Collections.Generic;

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

            var target = new FakeOrderService();
            var bookDao = Substitute.For<IBookDao>();
            target.SetBookDao(bookDao);

            target.SetOrderLists(new List<Order>()
            {
                new Order(){Type = "Book"},
                new Order(){Type = "CD"},
                new Order(){Type = "Book"},
            });
            target.SyncBookOrders();
            bookDao.Received(2).Insert(Arg.Is<Order>(order => order.Type.Equals("Book")));
        }
    }

    public class FakeOrderService : OrderService
    {
        private IBookDao _bookDao;
        private List<Order> _orderLists;

        protected override IBookDao GetBookDao()
        {
            return _bookDao ?? base.GetBookDao();
        }

        public void SetBookDao(IBookDao bookDao)
        {
            _bookDao = bookDao;
        }

        protected override List<Order> GetOrders()
        {
            return _orderLists ?? base.GetOrders();
        }

        public void SetOrderLists(List<Order> lists)
        {
            _orderLists = lists;
        }
    }
}