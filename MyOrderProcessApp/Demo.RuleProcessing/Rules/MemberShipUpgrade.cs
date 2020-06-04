using Demo.RuleProcessing.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.RuleProcessing.Rules
{
    public class MemberShipUpgrade : BaseRule
    {
        public MemberShipUpgrade(IDomainEntity domainEntity) : base(domainEntity)
        {
        }

        public override string ExecuteRule()
        {
            return $"Upgrade {base.ProductName}";
        }
    }
}
