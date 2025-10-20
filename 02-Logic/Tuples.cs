partial class Program {

    static void Tupples(){
        
        Console.WriteLine("TUPPLES");   

         (int, string, double) person = (1, "Tono", 99.9);
          WriteLine($"ID: {person.Item1} -> Name: {person.Item2} -> Score: {person.Item3}");

         (int id,string name) person2 = (2,"Ana");
          WriteLine($"ID: {person2.id} -> Name: {person2.name}");

          (int suma,int resta)=BasicOperations(10,5);
            WriteLine($"Suma: {suma} Resta: {resta}");

    }

    static (int Sum, int Subtract) BasicOperations(int a, int b){
        return (a + b, a - b);
    }
}