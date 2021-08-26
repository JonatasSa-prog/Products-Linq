using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace Product.Entities
{
    class Products
    {
        List<Product> products = new List<Product>();

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public int getProduct()
        {
            return products.Count;
        }

        public void getAvarage()
        {
            var avarage = products.Select(p => p.Value).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Avarage Price = " + avarage.ToString("F2", CultureInfo.InvariantCulture));

            var orderByAvarage = products.Where(p => p.Value < avarage).OrderByDescending(p => p.Name);
            foreach(Product name in orderByAvarage)
            {
                Console.WriteLine(name.Name);
            }
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach(Product p in products)
            {
                str.Append("Name: ");
                str.Append(p.Name + " ");
                str.Append("Price: ");
                str.AppendLine($"{p.Value}");
            }
            return str.ToString();       
        }
    }
}
