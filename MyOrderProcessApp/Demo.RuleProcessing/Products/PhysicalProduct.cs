using Demo.RuleProcessing.Products;

namespace Demo.RuleProcessing
{
    public class PhysicalProduct : IProductEntity
    {
        public int Amount { get; set; }
        public string Name { get; set; } ="Physical Product";
    }
}