//Створити імітацію магазину з товарами. 

//1. Додати клас VegetableShop, що може зберігати у собі різноманітні продукти. Також передбачити можливість поповнювати магазин новими продуктами.

//2. Додати класи, що являють собою продукти — Carrot, Potato, Tomato, Cucumber. Кожен овоч має приватне поле BasePrice, це ціна продукту.
//Але саме у картоплі та огірків ціна вказується за кілограм, тому для них ціна рахується за формулою Price = BasePrice * Count.
//Поле Count це кількість кілограмів продукту, це поле є тільки у картоплі і огірків, для всіх інших продуктів вважати що Price = BasePrice.

//3. Додати до класу VegetableShop можливість виводити повністю всю інформацію по наявних продуктах, зі вказуванням загальної ціни всіх продуктів.

//Приклад робочого коду з класу Main:

//Copy code
//var products = new List<Product>()
//{
//    new Carrot(15),
//    new Potato(20, 4),
//    new Cucumber(14, 2)
//};


//VegetableShop shop = new VegetableShop();
//shop.AddProducts(products);


//shop.PrintProductsInfo();


// Output:
// Product: Carrot, Price: 15
// Product: Potato, Price: 20, Count: 4, Total price: 80
// Product: Cucumber, Price: 14, Count: 2, Total price: 28
// Total products price: 123

public class Product
{
    public Product(string name, decimal baseprice)
    {
        Name = name;
        BasePrice = baseprice;
    }
    public string Name { get; }
    protected decimal BasePrice { get; }
    public virtual decimal GetPrice()
    {
        return BasePrice;
    }
    public virtual string GetInfo()
    {
        return $"Product: {Name}, Price: {BasePrice}";
    }
}

class Carrot : Product
{
    public Carrot(decimal basePrice)
        : base("Carrot", basePrice)
    {
    }
}

class Tomato : Product
{
    public Tomato(decimal basePrice)
        : base("Tomato", basePrice)
    {
    }
}

class Potato : Product
{
    public int Count { get; }

    public Potato(decimal basePrice, int count)
        : base("Potato", basePrice)
    {
        Count = count;
    }

    public override decimal GetPrice()
    {
        return BasePrice * Count;
    }
    public override string GetInfo()
    {
        return $"Product: {Name}, Price: {BasePrice}, Count: {Count}, Total price: {GetPrice()}";
    }
}


class Cucumber : Product
{
    public int Count { get; }

    public Cucumber(decimal basePrice, int count)
        : base("Cucumber", basePrice)
    {
        Count = count;
    }

    public override decimal GetPrice()
    {
        return BasePrice * Count;
    }
    public override string GetInfo()
    {
        return $"Product: {Name}, Price: {BasePrice}, Count: {Count}, Total price: {GetPrice()}";
    }
}
