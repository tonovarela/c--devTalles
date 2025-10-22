partial class Program {

    static void PathExample(){
        Console.WriteLine("***** Path Example *****");

        string path = "./05-Files/Example.txt";
        string fileName = Path.GetFileName(path);
        Console.WriteLine($"File Name: {fileName}");
        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
        Console.WriteLine($"File Name without Extension: {fileNameWithoutExtension}");
        string? extension = Path.GetExtension(path);
        Console.WriteLine($"Extension: {extension}");
        string? directoryName = Path.GetDirectoryName(path);
        Console.WriteLine($"Directory Name: {directoryName}");
        string? combinedPath = Path.Combine(directoryName ?? string.Empty, "NewFile.txt");
        Console.WriteLine($"Combined Path: {combinedPath}");

        
        
    }
}