partial class Program {
    static void TypeDiferences(){    
        int x =5;
        int y =x;
        y = 10;
        Console.WriteLine($"x: {x}, y: {y}"); 
        Person person1 = new Person {
            Name = "Tono"
        };
        Person persona2 = person1;
        persona2.Name = "Varela";
        Console.WriteLine($"person1: {person1.Name}, persona2: {persona2.Name}");    
    }
}


class Person {
    public string? Name {get; set;}

}