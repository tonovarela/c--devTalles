partial class Program  {

    static void HoweWork7()
    {
        Console.WriteLine("Ingrese un número entero:");


        List<Sale> sales = new List<Sale> {
            new Sale("Laptop", "Electrónica", 1500),
            new Sale("Teléfono", "Electrónica", 900),
            new Sale("Silla", "Muebles", 1200),
            new Sale("Escritorio", "Muebles", 800),
            new Sale("Tablet", "Electrónica", 1300),
            new Sale("Lámpara", "Iluminación", 400)
        };

        var salesPlusThousand = sales.Where(s => s.Amount > 1000);
        Console.WriteLine("Ventas con monto mayor a 1000:");
        PrintSales(salesPlusThousand.ToList());

        var groupedSales = sales.GroupBy(s => s.Category)
                          .Select(g => new { Category = g.Key, TotalAmount = g.Sum(s => s.Amount) });

        Console.WriteLine("\nVentas agrupadas por categoría:");
        foreach (var group in groupedSales)
        {
            Console.WriteLine($"Categoría: {group.Category}, Monto Total: {group.TotalAmount:C}");
        }
        
    }


    static void PrintSales(List<Sale> sales)
    {
        foreach (var sale in sales)
        {
            Console.WriteLine($"Producto: {sale.Product}, Categoría: {sale.Category}, Monto: {sale.Amount:C}");
        }
     
    }
        

    
}



class Sale
{
    public string? Product { get; set; }
    public string? Category { get; set; }
    public double Amount { get; set; }

    public Sale(string product, string category, double amount)
    {
        Product = product;
        Category = category;
        Amount = amount;
    }
}
