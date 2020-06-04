using Demo.RuleProcessing.Products;
using System;

namespace Demo.RuleProcessing.Rules
{
    public class PackingSlipRule:BaseBusinessRule
    {
        public PackingSlipRule(IDomainEntity domainEntity):base(domainEntity)
        {
        }

        /// <summary>
        /// Implmentation of PackagingSlip
        /// </summary>
        /// <returns></returns>
        public override string ExecuteRule()
        {
            //logic to generate packiing slip
            return $"packing slip executed for {base.ProductName}";
        }
    }
}