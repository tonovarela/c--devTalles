partial class Program {
    static void Conditionals() {
        Console.WriteLine("Conditionals");
    int day =10;
     string dayMessage = day switch {
            1=> "Start of the work week",
            4=> "End of the work week",
            5 or 6 => "It's the weekend!",
            _ => "It's a regular day"
        };

        Console.WriteLine(dayMessage);   

    }
}