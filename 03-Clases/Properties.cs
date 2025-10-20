partial class Program {
    static void Properties(){

        Console.WriteLine("Testing Properties...");

        Animal lion = new Animal("Savannah");
        lion.Species = "Lion";
        lion.Age = -5;

        Console.WriteLine($"Animal: {lion.Species}, Category: {lion.Category}, Habitat: {lion.Habitat}, Age: {lion.Age}");

        // Probando la validación en la propiedad Age
        lion.Age = -3; // Intento de asignar una edad negativa
        Console.WriteLine($"Updated Age (after invalid set): {lion.Age}");

    }
}

class Animal{
    
    public string? Species { get; set; } ="Unknown";
    public string Category { get;  } ="Vertebrados";
    private int age;
    public string Habitat { get; }     
    public int Age {
        get { return age; }
        set { 
            if (value < 0) {
                throw new ArgumentException("Age cannot be negative.");
            } else {
                age = value;
            }
         }
    }        
    public Animal(string habitat){
        Habitat = habitat;

    }
    
}