partial class Program {
    static void ListDictionary() {
        //Console.WriteLine("List Dictionary");
        List<string> list = new List<string>{"Tono","Carlos","Ana"};
        list.Add("Maria");
        list.Add("Lucia");
        
        //list.ForEach(Console.WriteLine);
        list.Remove("Ana");
        //Console.WriteLine("After remove Ana");
        list.ForEach(Console.WriteLine);
        bool isPresent = list.Contains("Carlos");
        // Console.WriteLine($"Is Carlos present? {isPresent}");
        // Console.WriteLine($"Count: {list.Count}");

        //Dictionary
        Dictionary<int,string> dictionary = new Dictionary<int,string>{
            {1,"Tono"},
            {2,"Carlos"},
            {3,"Ana"}
        };
        dictionary.Add(4,"Maria");                
        dictionary[5] = "Lucia"; //Another way to Add
        

        foreach(var item in dictionary) {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

    }
}