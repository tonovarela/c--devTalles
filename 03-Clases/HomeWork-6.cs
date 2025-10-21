partial class Program {

    public static void HomeWork6() {
        List<Employee> employees = new List<Employee> {
            new TeamLeader("Carlos", 5000),
            new Developer("Ana", 4000),
            new TeamLeader("Laura", 6000),
            new Developer("Luis", 3500)
        };

        foreach (var emp in employees) {
            emp.ShowInfo();
            emp.CalculateBonus();
            
        }
    }
}

class Employee {
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Position { get; set; }

    public Employee(string name, double salary, string position) {
        Name = name;
        Salary = salary;
        Position = position;
    }

    public virtual double CalculateBonus() {
        double bonus = Salary * 0.05; // 5% bonus
        Console.WriteLine($"Employee: {Name}, Position: {Position}, Bonus: {bonus}");
        return bonus;
        
    }
    public void ShowInfo(){
        Console.WriteLine($"Name: {Name}, Position: {Position}, Salary: {Salary}");
    }
}

 class TeamLeader:Employee {

    public TeamLeader(string name, double salary):base(name,salary,"Team Leader") {
        
    }
    public override double CalculateBonus() {
        double bonus = Salary * 0.1; // 10% bonus for team leaders
        Console.WriteLine($"Team Leader: {Name}, Bonus: {bonus}");
        return bonus;
    }

}

class Developer:Employee {
    public Developer(string name, double salary):base(name,salary,"Developer") {

    }

    public override double CalculateBonus() {
        double bonus = Salary * 0.07; // 10% bonus for developers
        Console.WriteLine($"Developer: {Name}, Bonus: {bonus}");
        return bonus;
    }
}