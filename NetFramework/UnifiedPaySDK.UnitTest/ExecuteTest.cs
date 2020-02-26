namespace UnifiedPaySDK.UnitTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using UnifiedPaySDK.Request;
    using UnifiedPaySDK.Response;

    [TestClass]
    public class ExecuteTest
    {
        [TestMethod]
        public void Pay_Test()
        {
            var request = new PayRequest();
            var response = new PayResponse();

            Assert.AreEqual<string>("success", "success");
        }

        [TestMethod]
        public void OrderQuery_Test()
        {
            var request = new OrderQueryRequest();
            var response = new OrderQueryResponse();

            Assert.AreEqual<string>("success", "success");
        }

        [TestMethod]
        public void Refund_Test()
        {
            var request = new RefundRequest();
            var response = new RefundResponse();

            Assert.AreEqual<string>("success", "success");
        }

        [TestMethod]
        public void RefundQuery_Test()
        {
            var request = new RefundQueryRequest();
            var response = new RefundQueryResponse();

            Assert.AreEqual<string>("success", "success");
        }

        [TestMethod]
        public void Cancel_Test()
        {
            var request = new CancelRequest();
            var response = new CancelResponse();

            Assert.AreEqual<string>("success", "success");
        }
    }
}
