using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Outings_Repository;

namespace Outings_Test
{
    [TestClass]
    public class MethodTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Content contentList = new Content();

            Content content = new Content();
            content.EventCost = 4000;
            double expected = 4000;
             


            Assert.AreEqual(expected, content.EventCost);

        }
    }
}
