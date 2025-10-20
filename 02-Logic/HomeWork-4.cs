partial class Program {

    static void PrintFactorialTable(int number){     
        int a =  CalcularFactorialRecursivo(a: number);
        WriteLine($"El factorial de {number} es: {a}");
        WriteLine("Tabla de factoriales:");
        Factorial(number);
    }




    static void Factorial(int a){        
        int result = 1;
        WriteLine($"Factorial del numero {a} desde el 1 hasta el {a} es:");
        for(int i = 1; i <= a; i++){
            result *= i;
            Console.WriteLine($"{i}! = {result}");
        }        
    }

    static int CalcularFactorialRecursivo(int a) {
        if (a <= 1) {
            WriteLine("1! = 1");
            return 1;
        }
        int res = a * CalcularFactorialRecursivo(a - 1);
        WriteLine($"{a}! = {res}");
        return res;
    }
}