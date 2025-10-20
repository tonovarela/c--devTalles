partial class Program
{
    static void TestingClasses()
    {
        Console.WriteLine("Testing Classes...");

        Vehicle myCar = new Vehicle("Toyota", "Corolla", 2020);
        myCar.ShowDetails();
        Vehicle myBike = new Vehicle {
            Brand = "Yamaha",
            Model = "MT-07",
            Year = 2021
        };
        myBike.ShowDetails();
        
    }
}


class Vehicle {
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int? Year { get; set; }

    public  Vehicle(string brand,string model,int year) {                        
                        Brand = brand;
                        Model = model;
                        Year = year;     
    }

    public Vehicle() { }

    public void ShowDetails() {
        Console.WriteLine($"Vehicle: {Brand} {Model}, Year: {Year}");
    }
}