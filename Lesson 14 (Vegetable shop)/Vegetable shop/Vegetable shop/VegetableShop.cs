using System;
using System.Collections.Generic;
using System.Text;

namespace Vegetable_shop
{
    public class VegetableShop
    {
        private List<Product> products = new List<Product>();

        public void AddProducts(List<Product> newProducts)
        {
            products.AddRange(newProducts);
        }

        public void PrintProductsInfo()
        {
            decimal total = 0;

            foreach (var product in products)
            {
                Console.WriteLine(product.GetInfo());
                total += product.GetPrice();
            }

            Console.WriteLine($"Total products price: {total}");
        }
    }
}
