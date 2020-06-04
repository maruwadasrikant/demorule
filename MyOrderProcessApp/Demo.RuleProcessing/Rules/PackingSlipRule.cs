using Demo.RuleProcessing.Products;
using System;

namespace Demo.RuleProcessing.Rules
{
    public class PackingSlipRule:BaseRule
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
            return $"packing slip executed for {base.ProductName}";
        }
    }
}