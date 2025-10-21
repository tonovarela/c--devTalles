partial class Program
{
    static string? amount;
    static void HandleException()
    {
        try {
            
            //int number = 10;
            Console.WriteLine("Ingrese un numero para dividir 10");
            amount = ReadLine();
            if (string.IsNullOrEmpty(amount))  return;                        
            bool isValid =double.TryParse(amount, out double amountValue);
            if (!isValid)
            {
                throw new FormatException("El valor ingresado no es un numero valido");
            }
            ValidateAge(15);
            
        }        
        catch(ArgumentException ex)
        {
         Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException)
        {         
            Console.WriteLine("No se puede dividir por cero");
        }
        catch(FormatException) when ( amount?.Contains('$') == true )
        {
            Console.WriteLine("Formato no valido");
        }
        catch(Exception ) {            
            Console.WriteLine($"Se produjo un error");
        }
        finally{
            Console.WriteLine("Gracias por usar la aplicacion");
        }
    }

    static void ValidateAge(int age){
        if (age < 18)
        {
            throw new ArgumentException("La edad debe ser mayor o igual a 18");
        }

    }
}
