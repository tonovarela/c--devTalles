
using System.Globalization;

partial class Program {

    static void ConvertionToDate(){
        Console.WriteLine("Convertions to Date");
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-MX");

        int friends = int.Parse("101");
        DateTime birthDate = DateTime.Parse("2 Marzo 2025");
        Double cost = 25.50;

        Console.WriteLine("La celebracion de mi cumpleanos es el: " + birthDate.ToString("dd-MM-yyyy")   );
        Console.WriteLine($"La celebracion de mi cumpleanos es el: {birthDate:D}"   );
        Console.WriteLine($"Tengo {friends} amigos.");
        Console.WriteLine($"El costo es: {cost:C}");

    }

}