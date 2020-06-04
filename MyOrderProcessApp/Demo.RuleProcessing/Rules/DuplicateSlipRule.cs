using Demo.RuleProcessing.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.RuleProcessing.Rules
{
    public class DuplicateSlipRule:BaseBusinessRule
    {
        public DuplicateSlipRule(IDomainEntity domainEntity) : base(domainEntity)
        {
        }


        public override string ExecuteRule()
        {
            //Logic to generate duplicate packing slip
            return "packing slip generated for royality department";
        }
    }
}
