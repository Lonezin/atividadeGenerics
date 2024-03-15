using System.Globalization;
using ListGeneric.Entities;
using ListGeneric.Services;

namespace Curso
{
    class Program
    {
        static void Main (string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string [] x = Console.ReadLine().Split(", ");
                string name = x[0];
                double price = double.Parse(x[1], CultureInfo.InvariantCulture);
                list.Add(new Product(price, name));
            }
            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);
            System.Console.WriteLine("Max: ");
            System.Console.WriteLine(max);
        }
    }
}