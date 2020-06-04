using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.RuleProcessing.Products
{
    public class Video: IProductEntity
    {
        public int Amount { get; set; }
        public string Name { get; set; } = "Video";
    }
}
