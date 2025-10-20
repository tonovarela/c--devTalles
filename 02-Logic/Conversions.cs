partial class Program {

    static void Conversions(){
        Console.WriteLine("Conversions");
        // int number =42;
        // double decimalNumber = number;
        // WriteLine(decimalNumber);


        // double explicitNumber=42.5;
        // int integerNumber = (int)explicitNumber;
        // WriteLine(integerNumber);

       //Convert o Parse

    //    string text ="123";
    //    int parsedNumber = int.Parse(text);
    //    Console.WriteLine(parsedNumber);


       // Convert 
       double anotherDecimalNumber = 50.8;
       int convertedNumber = Convert.ToInt32(anotherDecimalNumber);
       Console.WriteLine(convertedNumber);

       int castedNumber = (int)anotherDecimalNumber;
       Console.WriteLine(castedNumber);
    }
}