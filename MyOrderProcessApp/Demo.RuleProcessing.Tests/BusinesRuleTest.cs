using Demo.RuleProcessing.Products;
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

        [TestMethod]
        public void TestVideoPackingSlip()
        {
            Video video= new Video();
            VideoPackingSlipRule packingSlipRule = new VideoPackingSlipRule(video);
            var result = packingSlipRule.ExecuteRule();
            Assert.AreEqual("Video packing slip", result);
        }

        [TestMethod]
        public void TestActivateMemembership()
        {
            MemberShip memberShip= new MemberShip { User = "user1" } ;
            ActivateMememberShip  activateMemember= new ActivateMememberShip(memberShip);
            var result = activateMemember.ExecuteRule();
            Assert.AreEqual("Activated MememberShip", result);
        }

        [TestMethod]
        public void TestUpgradeMemberShip()
        {
            MemberShip memberShip= new MemberShip { User = "user2" };
            MemberShipUpgrade upgradeRule = new MemberShipUpgrade(memberShip);
            var result = upgradeRule.ExecuteRule();
            Assert.AreEqual("Upgrade MememberShip", result);
        }


    }
}
