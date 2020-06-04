using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection.Emit;

namespace Demo.RuleProcessing.Tests
{
    [TestClass]
    public class BusinesRuleTest
    {
        [TestMethod]
        public void TestPackagingSlip()
        {
            PhysicalProduct product= new PhysicalProduct();
            PackingSlipRule packingSlipRule = new PackingSlipRule();
            var result =packingSlipRule.ExecuteRule();
            Assert.AreEqual("packing slip generated", result);
        }
    }
}
