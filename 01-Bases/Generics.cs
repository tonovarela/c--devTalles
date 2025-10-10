partial class Program {
    static void Generics() {

        Console.WriteLine("Generics");
        int[] numbers = new int[] { 1, 2, 3,4 };
        string[] words = new string[] { "one", "two", "three"}; 

        // Console.WriteLine($"Length of int array: {GetIntArrayLength(numbers)}");
        // Console.WriteLine($"Length of string array: {GetStringArrayLength(words)}");
        // Console.WriteLine($"Length of int array (generic): {GetArrayLength<int>(numbers)}");
        // Console.WriteLine($"Length of string array (generic): {GetArrayLength<string>(words)}");
        Box<int> intBox = new Box<int> { Content = 123 };
        Box<string> strBox = new Box<string> { Content = "Hello Generics" };
        intBox.Show();
        strBox.Show();

    }

    static int GetArrayLength<T>(T[] array) {
        return array.Length;
    }


    // static int GetIntArrayLength(int[] numbers) {
    //     return numbers.Length;
    // }
    // static int GetStringArrayLength(string[] words) {
    //     return words.Length;
    // }
}

class Box<T> {
    public T? Content { get; set;  }

    public void Show(){
        Console.WriteLine($"Content: {Content}");
    }
}