partial class Program {

    static void HomeWork5() {


     Inventory inventory = new Inventory();
        Product product1 = new Product("Laptop", 1200.00, 10);
        Product product2 = new Product("Smartphone", 800.00, 20);
        Product product3 = new Product("Headphones", 150.00, 15);
        inventory.AddProduct(product1);
        inventory.AddProduct(product2);
        inventory.AddProduct(product3);
        
        inventory.DisplayInventory();
        product1.Sell(3);
        inventory.DisplayInventory();

     


    }

class Inventory {
    private List<Product> products;

    public Inventory() {
        products = new List<Product>();
    }

    public void AddProduct(Product product) {
        products.Add(product);
    }

    public void DisplayInventory() {
        foreach (Product product in products) 
            product.DisplayInfo();
        
    }
}

    class Product {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public Product(string name, double price, int stock) {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void DisplayInfo() {
            Console.WriteLine($"Product: {Name}, Price: {Price}, Stock: {Stock}");
        }

        public bool Sell(int quantity) {
            if (quantity <= Stock) {
                Stock -= quantity;
                WriteLine($"Sold {quantity} of {Name}. Remaining stock: {Stock}");
                return true;
            } else {
                WriteLine($"Insufficient stock for {Name}. Available stock: {Stock}");
                return false;
            }

        }



    }
}

