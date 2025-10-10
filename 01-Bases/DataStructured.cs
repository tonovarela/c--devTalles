partial class Program  {
    static void DataStructured()
    {         
        User user1 = new User { Name = "Alice", Age = 30 };        
        user1.Greet();
        Point point1 = new Point { X = 10, Y = 20 };
        Console.WriteLine($"Point coordinates: ({point1.X}, {point1.Y})");

        CellPhone cellPhone1 = new CellPhone ("iPhone", 2020);
        Console.WriteLine($"CellPhone: {cellPhone1.Model}, Year: {cellPhone1.Year}");        

    }
}

record CellPhone(string Model,int Year);

struct Point {

    public int X {get;set;}
    public int Y {get;set;}
}


class User {
    public string? Name { get; set; }

    public int Age { get; set; }

    public void Greet() {
        Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old.");
    }

}