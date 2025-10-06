using System.Globalization;
partial class Program
{

    static void DaysUntilNextBirthday()
    {
    Console.WriteLine("Calculadora de Dias hasta el proximo Cumpleanos");
    Console.Write("Ingrese su fecha de nacimiento (yyyy-MM-dd): ");
    string input = Console.ReadLine()!;
    DateTime currentDate = DateTime.Now;
    DateTime fechaNacimiento = DateTime.ParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture);

    DateTime proximoCumpleanos = new DateTime(currentDate.Year, fechaNacimiento.Month, fechaNacimiento.Day);
    if (proximoCumpleanos < currentDate)
    {
        proximoCumpleanos = proximoCumpleanos.AddYears(1);
    }
    TimeSpan diasRestantes = proximoCumpleanos - DateTime.Now;
    Console.WriteLine($"Tu proximo cumpleaños es en  {proximoCumpleanos.ToShortDateString()}");
    Console.WriteLine($"Faltan {diasRestantes.Days} días para tu próximo cumpleaños.");    
    }
}