

partial class Program {

    static void showTime(){
        Console.WriteLine("Fecha y Hora Actual");
        DateTime now = DateTime.Now;
        Console.WriteLine($"Ahora: {now}");
        DateTime today = DateTime.Today;   
        Console.WriteLine($"Hoy: {today}"); 
        DateTime nowWeekAgo = now.AddDays(-7);
        Console.WriteLine($"Hace una semana: {nowWeekAgo}");
        DateTime custom = new DateTime(2025,12,1);
        Console.WriteLine($"Custom: {custom.ToString("dd-MM-yyyy HH:mm")}");
        //DateTime nextMonth = now.AddMonths(1);
        //DateTime nextYear = now.AddYears(1);

        DayOfWeek dayOfWeek = now.DayOfWeek;
        Console.WriteLine($"Día de la semana: {dayOfWeek}");
    }

    
}