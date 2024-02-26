public Product(string productName, decimal price)
{
    ProductName = productName;
    Price = price;
}

public void DisplayProductDetails()
{
    Console.WriteLine("Product Name: " + ProductName);
    Console.WriteLine("Price: " + Price.ToString("C"));
}
}

class Program
{
    static void Main(string[] args)
    {
        Product apple = new Product("Apple", 0.5m);
        Product banana = new Product("Banana", 0.3m);
        Product orange = new Product("Orange", 0.75m);

        apple.DisplayProductDetails();
        banana.DisplayProductDetails();
        orange.DisplayProductDetails();

        Console.ReadKey();
    }
}
