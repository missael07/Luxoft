using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeChallenge;
namespace ChangeReturnTest
{
    [TestClass]
    public class ChangeReturnTests
    {
        [TestMethod]
        public void TestReturnUSCurrency()
        {
            GetMinimunChangeBillsAndCoins getMinimunChange = new GetMinimunChangeBillsAndCoins("US");
            float priceItem = 5.25f;
            float cashReceived = 6;            
            Assert.IsNotNull(getMinimunChange.MinimunChangeToReturn(cashReceived - priceItem));
        }

        [TestMethod]
        public void TestReturnMXCurrency()
        {
            GetMinimunChangeBillsAndCoins getMinimunChange = new GetMinimunChangeBillsAndCoins("MX");
            float priceItem = 100.25f;
            float cashReceived = 120;
            Assert.IsNotNull(getMinimunChange.MinimunChangeToReturn(cashReceived - priceItem));
        }

    }
}
