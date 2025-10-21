partial class Program {
    static void Methods() {
        Console.WriteLine("Testing Methods...");        
        Car myCar = new Car();
        myCar.Model = "Toyota";
        myCar.Year = 2020;
        myCar.ChangeModel("Honda");
        
        Car sportCar = new Car("Ferrari",2020);        
        Car collectionCar = new Car{
                                Model = "Ford Mustang",
                                Year = 1967
                                };
        Console.WriteLine(collectionCar.ShowInfo());

        List<Car> garage = new List<Car>{
            new Car("Chevrolet Camaro", 2018),
            new Car("Dodge Charger", 2019),
            new Car("BMW M3", 2021)
        };
        Console.WriteLine("Listado de automoviles: ");
        foreach (Car car in garage) 
            Console.WriteLine(car.ShowInfo());
                 
    }
}

class Car {
    public string?  Model { get; set; }
    public int?  Year { get; set; }


 ~Car(){
    Console.WriteLine($"The car {Model} is being destroyed.");
}
public Car() {
    Model = "Unknown";
    Year = 0;
}

public Car(string model, int year) {
        Model = model;
        Year = year;
}
    public void ChangeModel(string newModel) {
        Model = newModel;
    }

    public string ShowInfo() {
        return $"Model: {Model}, Year: {Year}";
    }

    public void ShowMessage() => Console.WriteLine("This is a car.");
    public void ShowMessage(string mensaje) => Console.WriteLine(mensaje);


    public static void StaticMethod() {
        Console.WriteLine("This is a static method.");
    }
    


}