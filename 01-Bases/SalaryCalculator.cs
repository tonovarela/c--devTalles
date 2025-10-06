partial class Program 
{
    static void SalaryCalculator(){
        Console.WriteLine("Calculadora de Salarios");

        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine()!;
        Console.Write("Ingrese el numero de horas trabajadas: ");
        int horasTrabajadas = int.Parse(Console.ReadLine()!);
        Console.Write("Ingrese el salario por hora: ");
        double salarioPorHora = double.Parse(Console.ReadLine()!);

        double salarioTotal = horasTrabajadas * salarioPorHora;
        Console.WriteLine($"El salario total de {nombre} es: {salarioTotal:C}");
        
    }
}