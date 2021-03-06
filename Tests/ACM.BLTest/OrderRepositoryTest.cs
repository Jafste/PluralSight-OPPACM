﻿using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //assert
            var orderRepository =  new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //actual
            var actual = orderRepository.Retrieve(10);

            //assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
        }
    }
}
