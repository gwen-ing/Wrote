class Product
{

    public string? Color { get; set; } 
    public decimal? Price { get; set; }
    public string? Name { get; set; }
    public string? Category  { get; set; }
    public string? Size { get; set; }

    static void Main()
    {
        /*var cool = new { Amount = 100, Message = "Pesos" };
        Console.WriteLine($"{cool.Amount} {cool.Message}");*/

        var product = new Product();
        var bonus = new { note = "You've won" };
        var shipment = new { Address = "Nowhere St.", product };
        var shipmentwithbonus = new { Address = "Nowhere St.", product, bonus };

        var array = new[] { new { name = "Fruit"}, new { name = "Meat" }};

        var apple = new { Item = "apples", Price = 1.35 };
        var onSale = apple with { Price = 0.79 };
        Console.WriteLine(apple);
        Console.WriteLine(onSale);

        var v = new { Title = "Hello", Age = 24 };

        Console.WriteLine(v.ToString());
    }

}
