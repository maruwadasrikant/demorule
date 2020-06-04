using Demo.RuleProcessing.Rules;
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
            PackingSlipRule packingSlipRule = new PackingSlipRule(product);
            var result =packingSlipRule.ExecuteRule();
            Assert.AreEqual("packing slip executed for Physical Product", result);
        }
    }
}
