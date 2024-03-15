using System.Globalization;

namespace ListGeneric.Entities
{
    public class Product
    {
        public double Price { get; set; }  
        public string Name { get; set; }

        public Product (double price, string name)
        {
            Price = price;
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}"; 
        }
    }
}