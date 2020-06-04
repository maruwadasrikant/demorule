using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.RuleProcessing.Products
{
    public class MemberShip : IDomainEntity
    {
        public string Name { get; set; } = "MememberShip";

        public string User { get; set; }
    }
}
