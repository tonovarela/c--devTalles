partial class Program {

 
   public static void Visibility() 
 {
    Console.WriteLine("03 - Clases - Visibility");

    Jedi jedi = new Jedi();
    jedi.LightSaberColor = "Azul";
    jedi.PowerLevel = 50000;
    jedi.UseForce();    
    Sith sith = new Sith();
    sith.LightSaberColor = "Rojo";
    sith.PowerLevel = 60000;
    sith.UseForce();
       
}

}

interface IForceUser {
    int PowerLevel { get; set; }
    string? LightSaberColor { get; set; }
    void UseForce();
    
}

class Jedi :IForceUser {    
    public int PowerLevel  { get;  set; } 
    public string? LightSaberColor { get;  set; }
    public void UseForce() =>Console.WriteLine($"Yo soy un Jedi con un sable de luz {LightSaberColor} y un nivel de poder de {PowerLevel}");    
    protected void TrainPadawan()=> Console.WriteLine("Training a Padawan in the ways of the Force");

    private void Meditate() {        
        Console.WriteLine("Meditating to increase power level");
        PowerLevel += 1000;
    }    
}

class Sith : IForceUser {

    public int PowerLevel { get; set; }
    public void UseForce() => Console.WriteLine($"Yo soy un Sith con un sable de luz {LightSaberColor} y un nivel de poder de {PowerLevel}");
    public string? LightSaberColor { get; set; }
    public void ShowHiddenStrengths() => Console.WriteLine("Mostrando habilidades ocultas del Sith:");        

    
}