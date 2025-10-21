partial class Program {

    static void Collections() {
        Console.WriteLine("Collections Demo");
        // List<string> names = new List<string>();
        // names.Add("Alice");
        // names.Add("Diana");
        // names.Add("Ethan");
        // names.Add("Fiona");
        // showNames(names);
        // names.Remove("Alice");
        // showNames(names);
        // Dictionary<int, string> users = new Dictionary<int, string>();
        // users.Add(1, "Admin");
        // users.Add(2, "Guest");
        // users.Add(3, "Moderator");        
        
        // ShowElements(users);        
        HashSet<string> colors = new HashSet<string>();
        colors.Add("Red");
        colors.Add("Green");
        colors.Add("Blue");
        colors.Add("Red"); // Intento de agregar un duplicado

        foreach (var color in colors) {
            Console.WriteLine($"Color: {color}");
        }
    }


    static void ShowElements(Dictionary<int, string> dict) {
        foreach (var item in dict) {
            Console.WriteLine($"Llave: {item.Key}, Valor: {item.Value}"); 
        }

    }


     static void showNames(List<string> names) {
        Console.WriteLine();
        Console.WriteLine("*****Inicio de Nombres*****");
        foreach (string name in names) 
            Console.WriteLine(name);        
        Console.WriteLine("*****Fin de Nombres*****");
        Console.WriteLine();
    }


}