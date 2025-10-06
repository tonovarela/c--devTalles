partial class Program
{
    static void SalesReport()
    {
        string product ="Laptop";
        int quantitySold = 3;
        double unitPrice = 799.99;
        double totalSales = quantitySold * unitPrice;
        Console.WriteLine("Sales Report");
        Console.WriteLine("--------------");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quantity Sold: {quantitySold}");
        Console.WriteLine($"Unit Price: {unitPrice:C}");
        Console.WriteLine($"Total Sales: {totalSales:C}");

    }
}