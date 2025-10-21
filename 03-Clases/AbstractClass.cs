  partial class Program {

    public static void AbstractClassDemo(){
       HomeAppliance myWasher = new WashingMachine(){ Brand = "LG" };
       HomeAppliance myMicrowave = new MacroWave(){ Brand = "Samsung" };
       myWasher.ShowBrand();
       myWasher.TurnOn();
       myMicrowave.ShowBrand();
       myMicrowave.TurnOn();        
    }


}

abstract class HomeAppliance {
    public string? Brand {get; set;}
    public abstract void TurnOn();
    public void ShowBrand()=> Console.WriteLine($"The brand of this appliance is: {Brand}");

}

class WashingMachine : HomeAppliance {
    
    public override void TurnOn()=>Console.WriteLine("🌀 The washing machine is now ON. Starting the wash cycle.");    
}

class MacroWave : HomeAppliance {    

    public override void TurnOn()=>Console.WriteLine("🔥 The microwave is now ON. Heating your food.");

    
}