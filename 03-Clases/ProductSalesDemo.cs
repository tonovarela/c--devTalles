partial class Program {

    static void ProductSalesDemo(){
        Console.WriteLine("Product Sales Demo");

        Bus bus1 = new Bus("Volvo", "XC90", 2020, 80000);
        Bus bus2 = new Bus("Mercedes", "Sprinter", 2019, 60000);
        Bus bus3 = new Bus("Ford", "Transit", 2021, 55000);
        Fleet fleet = new Fleet();
        fleet.AddBus(bus1);
        fleet.AddBus(bus2);
        fleet.AddBus(bus3);
        fleet.ShowFleetDetails();
        bus1.Drive(150000);
        bus2.Drive(200);
        fleet.ShowFleetDetails();    
    }
    

    class Bus {
        public string Brand {get; set;}
        public string Model {get; set;}
        public int Year {get; set;}
        public double Price {get; set;}
        public int TotalKilometers {get; set;}
        public Bus(string brand, string model, int year, double price){
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            TotalKilometers = 0;
        }

        public void Drive(int kilometers){
            Console.WriteLine($"Driving the bus {Brand} {Model} for {kilometers} kilometers.");
            TotalKilometers += kilometers;
        }

        public void ShowPrice(){
            Console.WriteLine($"The price of the bus {Brand} {Model} is {Price:C}");
        }

    }

    class Fleet {
        private List<Bus> buses;
        public Fleet(){
            buses = new List<Bus>();
        }
        public void AddBus(Bus bus){
            buses.Add(bus);
        }
        public void ShowFleetDetails(){
            foreach(var bus in buses){
                Console.WriteLine($"Bus: {bus.Brand} {bus.Model}, Year: {bus.Year}, Price: {bus.Price:C}, Total Kilometers: {bus.TotalKilometers}");
            }
        }
    }
}