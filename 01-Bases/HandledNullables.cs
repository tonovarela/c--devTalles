partial class Program {
    static void HandledNullables(){

      string firstName = "Varela";
      string? middleName = null;      
      Console.WriteLine($"Hello {firstName} {middleName?.ToUpper() ?? "No Middle Name"}");

      string? text  = null;
      Console.WriteLine(text?.Length);
      Console.WriteLine("Sigue ejecutando ...");

    }
}
