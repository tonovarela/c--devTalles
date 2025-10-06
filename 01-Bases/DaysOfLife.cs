partial class Program {


    static void DaysOfLife(){
        Console.WriteLine("Calculadora de Dias Vividos");

       DateTime fechaNacimiento = new DateTime(1982, 8, 17); 
       TimeSpan edad = DateTime.Now - fechaNacimiento;
       int diasVividos = (int)edad.TotalDays;

    Console.WriteLine($"Has vivido aproximadamente {diasVividos} dias.");
 
    }
}