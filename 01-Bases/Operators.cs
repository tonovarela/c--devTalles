partial class Program {

    static void Operators(){

      Console.WriteLine("Operators");   
      int number =16;
      bool isEven = number % 2 == 0;
      bool isGreaterThanTen = number>10;

      Console.WriteLine($" isEven {isEven}, isGreaterThanTen {isGreaterThanTen}");
      if (isEven && isGreaterThanTen){
        Console.WriteLine($"El numero {number} es par y mayor que 10");
      }else 
      if (!isEven && isGreaterThanTen){
           Console.WriteLine($"Es numero {number} es impar y es mayor que 10");
      }else {
        Console.WriteLine($"El numero {number} no cumple con las condiciones");
      }

       int age = 21;
       string categoria = age >18 ? "Adulto":"Menor";
       Console.WriteLine($"La categoria es {categoria}");


     
    }
}