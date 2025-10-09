partial class Program {

     static void InventoryManager(){        
    Console.WriteLine("Inventory Manager");
    
    InventoryManager inventory = new InventoryManager([
        new Articulo{ Nombre="Monitor", Stock=10, Precio=250.50 },
        new Articulo{ Nombre="Mouse", Stock=25, Precio=20.50 },
        new Articulo{ Nombre="Teclado", Stock=30, Precio=45.00 }
    ]);
    inventory.mostrarArticulos();
             
    Console.WriteLine("1.- Comprar producto");
    Console.WriteLine("2.- Salir");

    Console.Write("Seleccione una opción: ");
    string? option = Console.ReadLine();
    if (option == "2") {
        Console.WriteLine("Gracias por su visita");
        return;
    }
     inventory.mostrarArticulos();
     
     Console.WriteLine("Ingrese el nombre del producto a buscar:");
     string? searchedProduct = Console.ReadLine();
     Articulo? articuloEnStock = inventory.buscarArticulo(searchedProduct??" " );
     
     if (articuloEnStock == null) {
        Console.WriteLine($"El producto {searchedProduct} no se encuentra en el inventario.");
        return;
     }

      Console.WriteLine("\nIngrese la cantidad a comprar:");     
      int quantityToBuy = int.Parse(Console.ReadLine() ?? "0");  
      if (!inventory.comprarArticulo(searchedProduct??" ", quantityToBuy)){
        return;
      }
      inventory.mostrarArticulos();
      
     

     }

}

public class InventoryManager {

    private Articulo[] _articulos;
    
    public InventoryManager(Articulo[] articulos) {    
        _articulos = articulos;
    }
      

    public void mostrarArticulos() {
        foreach (var articulo in this._articulos)        
            Console.WriteLine($"Articulo: {articulo.Nombre}, Stock: {articulo.Stock}, Precio: {articulo.Precio}");                    
    }

    public Articulo? buscarArticulo(string nombre) {
        return this._articulos.FirstOrDefault(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }

    public bool comprarArticulo(string nombre, int cantidad) {
        var articulo = buscarArticulo(nombre);
        if (articulo == null) {
            Console.WriteLine($"El producto {nombre} no se encuentra en el inventario.");
            return false;
        }
        if (cantidad <= 0) {
            Console.WriteLine("Cantidad inválida. Debe ser un número positivo.");
            return false;
        }
        if (cantidad > articulo.Stock) {
            Console.WriteLine($"No hay suficiente stock de {nombre}. Stock disponible: {articulo.Stock}");
            return false;
        }
        articulo.Stock -= cantidad;
        double totalPrice = cantidad * articulo.Precio;
        Console.WriteLine($"Compra exitosa de {cantidad} unidades de {nombre}. Precio total: {totalPrice}");
        return true;
    }
    
}

public  class Articulo {
public required string Nombre { get; set; }
public int Stock { get; set; }
public double Precio { get; set; }
  

}