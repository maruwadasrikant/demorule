using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.RuleProcessing.Products
{
    interface IProductEntity:IDomainEntity
    {
        public int Amount { get; set; }
    }
}
