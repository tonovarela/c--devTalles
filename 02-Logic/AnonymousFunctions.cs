partial class Program
{
    static void AnonymousFunctions()    
    {
        // Console.WriteLine("ANONYMOUS FUNCTIONS");
        // int result1 = square(5);
        // WriteLine($"Square of 5 is: {result1}");
        // var e =lambdaSquare(6);
        // WriteLine($"Square of 6 is: {e}");
        List<int> numbers = new List<int>(){1,2,3,4,5,6,7,8,9,10};
        var evenNumbers = numbers.Where(x => x % 2 == 0);
        //.Select(lambdaSquare);
        // WriteLine("Squares from 1 to 10:");
        foreach(var item in evenNumbers){
            WriteLine(item);    
        }

   

    }

    static Func<int,int> square = delegate(int x){
        return x * x;
    };

    static Func<int,int> lambdaSquare = x => x * x ;
}