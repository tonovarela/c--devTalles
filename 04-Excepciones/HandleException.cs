partial class Program
{
    static string? amount;
    static void HandleException()
    {
        try {
            
            int number = 10;
            Console.WriteLine("Ingrese un numero para dividir 10");
            amount = ReadLine();
            if (string.IsNullOrEmpty(amount))  return;                        
            double amountValue =10/ double.Parse(amount);
            Console.WriteLine($"10 dividido por {amountValue:C} es {(number / amountValue):C}");
        }        
        catch (DivideByZeroException)
        {         
            Console.WriteLine("No se puede dividir por cero");
        }
        catch (FormatException) when ( amount?.Contains('$') == true )
        {
            Console.WriteLine("Formato no valido");

        }
        catch(Exception ) {            

            Console.WriteLine($"Se produjo un error");
        }
    }
}
