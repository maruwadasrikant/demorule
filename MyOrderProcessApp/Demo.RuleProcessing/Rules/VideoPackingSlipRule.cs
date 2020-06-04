using Demo.RuleProcessing.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.RuleProcessing.Rules
{
    public class VideoPackingSlipRule : BaseBusinessRule
    {
        public VideoPackingSlipRule(IDomainEntity domainEntity) : base(domainEntity)
        {
        }
        public override string ExecuteRule()
        {  
            return "Video packing slip";
        }
    }
}
