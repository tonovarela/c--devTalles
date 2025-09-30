partial class Program {
    

    static void StringTypes() {      
        Console.WriteLine("String Types");
        string greeting = "Hello, World!";
        int numero = 42;
        //char firstLetter = 'H';
        string multiLineString = @"This is a multi-line string.
        
        It can span multiple lines.";
        string interpolatedString = $"Greeting: {greeting}";

        Console.WriteLine(greeting.ToUpper());
        Console.WriteLine(greeting.ToLower());        
        Console.WriteLine(numero.ToString());
        //Console.WriteLine($"First Letter: {firstLetter}");
        Console.WriteLine(multiLineString.Length );
        //Console.WriteLine(interpolatedString);
    }
}