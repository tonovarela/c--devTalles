partial class Program {
    public static void Herencia(){

        Console.WriteLine("Herencia Demo");
        HowgartsStudent howartsStudent= new HowgartsStudent(){ Name = "Harry Potter", House = "Gryffindor" };        
        howartsStudent.Greet();
        HowgartsProfesor howartsProfesor= new HowgartsProfesor(){ Name = "Severus Snape", Subject = "Potions" };

        howartsProfesor.Greet();
        howartsStudent.ShowHouse();
        howartsProfesor.MySubject();

    }

    class Character {
        public string? Name {get; set;}
        public virtual void Greet()=> Console.WriteLine($"Hello, I am a character. My name is {Name}");
        
    }

    class HowgartsStudent : Character {

        public string? House {get; set;}

        public override void Greet()=> Console.WriteLine($"Hello, I am a Howgarts student. My name is {Name}");
        

        public void ShowHouse()=> Console.WriteLine($"I belong to the house: {House} en Hogwarts.");
        
    }

     class HowgartsProfesor : Character {

        public string? Subject {get; set;}

        public override void Greet()=> Console.WriteLine($"Hello, I am a Hogwarts professor. My name is {Name}");
            
        public void MySubject()=> Console.WriteLine($"I teach the subject: {Subject} en Hogwarts.");
        
    }
}