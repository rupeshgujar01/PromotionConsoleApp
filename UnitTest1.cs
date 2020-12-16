using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using PromotionConsoleApp;

namespace PromotionTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetTotal()
        {
            int total =  PromotionConsoleApp.Program.CalculateTotal(4,3,2,3);
            Assert.IsNotNull(total);
        }
    }
}
