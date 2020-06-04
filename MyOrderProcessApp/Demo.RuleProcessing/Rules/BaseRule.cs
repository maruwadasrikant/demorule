using Demo.RuleProcessing.Products;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Demo.RuleProcessing.Rules
{
    public abstract class BaseRule
    {
        IDomainEntity _domainEntity;
        public BaseRule(IDomainEntity domainEntity)
        {
            _domainEntity = domainEntity;
        }


        public string ProductName => _domainEntity.Name;
        
        public abstract string ExecuteRule();
        
    }
}
