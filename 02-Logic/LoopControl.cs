partial class Program {

    static void  LoopControl(){
    Console.WriteLine("Loop control");

    // for(int i=0;i<10;i++) { //Te saca de la funcion
    //     if(i==5){ return; }            
    //     WriteLine(i);        
    // }

    for(int i=0;i<10;i++) {
        if(i==5){ break; }            
        WriteLine(i);        
    }

    for(int i=0;i<10;i++) {
        if(i==5){ continue; }            
        WriteLine(i);        
    }


    }


}