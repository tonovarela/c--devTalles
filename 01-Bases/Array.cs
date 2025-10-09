partial class Program {

    static void Arrays() {        

    int[] numbers = new int[5];
    numbers[0] =1;
    numbers[1] =2;
    int[] numbers1 = {5,10,20,50,60};

    Console.WriteLine(numbers[1]);
    //Console.WriteLine(numbers1[0]);
    Console.WriteLine($"El numero de elementos es {numbers.Length}");


   Console.WriteLine(numbers1[numbers1.Length-1]);


   var firsThree = numbers1[..2];

   foreach(var number in firsThree){
     Console.Write(number);
   }





    }
}