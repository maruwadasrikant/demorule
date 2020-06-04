using Demo.RuleProcessing.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.RuleProcessing.Rules
{
    public class ActivateMememberShip:BaseBusinessRule
    {
        public ActivateMememberShip(IDomainEntity domainEntity) : base(domainEntity)
        {
        }
        public override string ExecuteRule()
        {
            //Logic to activate the memmbers
            this.NotifyEmail();
            return $"Activated {base.ProductName}";
        }
    }
}
