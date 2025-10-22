partial class Program {

    static void DirectoryExample(){
        var directoryPath = "./05-Files/";
        

        string path = $"{directoryPath}/MyDirectory";
        if (Directory.Exists(path)) {            
            Console.WriteLine("Directory already exists.");
            Directory.Delete(path, true);
            return;            
        } 

        Console.WriteLine("Directory created successfully.");
        Directory.CreateDirectory(path);

        
      
    }

}