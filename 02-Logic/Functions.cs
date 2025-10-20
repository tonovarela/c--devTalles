partial class Program {

    static double CalculateArea(double width,double height) {
        return width * height;        
    }
    static string EvaluateNumber(int number){        
        if(number ==0 ){
            return "Zero";
        }
        return number > 0 ? "Positive" : "Negative";        
    }

    static void Functions() {
        // double area = CalculateArea(10,20);
        // WriteLine($"Area: {area}");        
        WriteLine($"EvaluateNumber(5): {EvaluateNumber(5)}");
        WriteLine($"EvaluateNumber(-3): {EvaluateNumber(-3)}");
        WriteLine($"EvaluateNumber(0): {EvaluateNumber(0)}");
        
    }



}