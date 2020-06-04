using Demo.RuleProcessing.Products;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Demo.RuleProcessing.Rules
{
    public abstract class BaseBusinessRule
    {
        IDomainEntity _domainEntity;
        public BaseBusinessRule(IDomainEntity domainEntity)
        {
            _domainEntity = domainEntity;
        }

        public string ProductName => _domainEntity.Name;
        
        public abstract string ExecuteRule();
        

        public bool NotifyEmail()
        {
            Console.WriteLine("Logic to send email");
            return true;
        }

        public bool CalculateCommission()
        {
            //Logic to calculate the commission
            Console.WriteLine("commission calculated");
            return true;
        }
    }
}
