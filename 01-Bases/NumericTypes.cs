partial class Program {
    

    static void NumericTypes() {        

        Console.WriteLine("Numeric Types");
        int integerNumber = 42;
        decimal decimalNumber = 3.141592m;
        double floatNumber = 2.71828f;
        double doubleNumber = 1.6180339887;
        
        Console.WriteLine($"Integer: {integerNumber}");
        Console.WriteLine($"Double: {doubleNumber}");
        Console.WriteLine($"Float: {floatNumber}");
        Console.WriteLine($"Decimal: {decimalNumber}");


    //    // Additional numeric type examples
       long longNumber =300_200_100L;
       short shortNumber = 32767;
       byte byteNumber = 255;

        Console.WriteLine($"Long: {longNumber}");
       Console.WriteLine($"Short: {shortNumber}");
       Console.WriteLine($"Byte: {byteNumber}");

    }

    
}