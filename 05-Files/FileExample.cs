partial class Program {


    static void FileExample(){

        const string filePath = "./05-Files/Example.txt";        
        string content = File.ReadAllText(filePath);        
        var lines = File.ReadAllLines(filePath);
        foreach(var line in lines){
            WriteLine(line);  
        }              
    //    File.Copy(filePath, "./05-Files/ExampleCopy.txt", overwrite:true);
  //      WriteLine("File copied successfully to ExampleCopy.txt");
        //File.Delete("./05-Files/ExampleCopy.txt");
//        WriteLine("ExampleCopy.txt deleted successfully.");
    }
}