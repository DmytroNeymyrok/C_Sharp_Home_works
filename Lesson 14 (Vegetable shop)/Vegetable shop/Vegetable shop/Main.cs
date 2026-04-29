using System;
using System.Collections.Generic;
using Vegetable_shop;

class Program
{
    static void Main()
    {
        var products = new List<Product>()
        {
            new Carrot(15),
            new Potato(20, 4),
            new Cucumber(14, 2),
            new Tomato(10)
        };

        VegetableShop shop = new VegetableShop();

        shop.AddProducts(products);

        shop.PrintProductsInfo();
    }
}