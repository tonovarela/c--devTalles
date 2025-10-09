partial class Program {

     static void InventoryManager(){        
        Console.WriteLine("Inventory Manager");
        Articulo[] articulos = {
            new Articulo{ Nombre="Monitor", Stock=10, Precio=250.50 },
            new Articulo{ Nombre="Mouse", Stock=25, Precio=20.50 },
            new Articulo{ Nombre="Teclado", Stock=30, Precio=45.00 }
        };
        foreach (var articulo in articulos)        
            Console.WriteLine($"Articulo: {articulo.Nombre}, Stock: {articulo.Stock}, Precio: {articulo.Precio}");                    
     
     Console.WriteLine("Ingrese el nombre del producto a buscar:");
     string? searchedProduct = Console.ReadLine();
     Console.WriteLine("Ingrese la cantidad a comprar:");
     int quantityToBuy = int.Parse(Console.ReadLine() ?? "0");  

     }

}

public  class Articulo {
public string Nombre { get; set; }
public int Stock { get; set; }
public double Precio { get; set; }
  

}