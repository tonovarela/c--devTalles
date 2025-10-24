using BetterConsoleTables;

namespace TaskMaster
{
  public class Queries(List<Task> _tasks)
  {
    private List<Task> Tasks = _tasks;

    public void ListTasks(){
    ForegroundColor = ConsoleColor.DarkBlue;
    WriteLine("------------Lista de Tareas-----------");
     Table  table = new Table("Id", "Descripción", "Estado");     
     table.Config =TableConfiguration.Unicode();
      foreach (var task in Tasks)      
         table.AddRow(task.Id, task.Description, task.Completed?"Completada":"Pendiente");
                  
     Console.Write(table.ToString());
     Console.ReadKey();        
     ForegroundColor = ConsoleColor.White;
    }

    public List<Task> AddTask(){
      //Console.Write("Ingrese la descripción de la tarea: ");

      try {

      }catch (Exception ex){
        Console.WriteLine($"Error al agregar la tarea: {ex.Message}");
      }
   



    }
}



