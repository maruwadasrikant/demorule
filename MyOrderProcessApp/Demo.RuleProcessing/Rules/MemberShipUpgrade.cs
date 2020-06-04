using Demo.RuleProcessing.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.RuleProcessing.Rules
{
    public class MemberShipUpgrade : BaseBusinessRule
    {
        public MemberShipUpgrade(IDomainEntity domainEntity) : base(domainEntity)
        {
        }

        public override string ExecuteRule()
        {
            //logic to upgrade memmbership using domain entity
            this.NotifyEmail(); //send email
            return $"Upgrade {base.ProductName}";
        }
    }
}
