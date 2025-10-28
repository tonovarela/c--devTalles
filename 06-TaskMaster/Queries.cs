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

    public List<Task> TasksByDescription(){
      try {
        ResetColor();
        Clear();
        WriteLine("------Consultar Tarea por Descripción------");
        Write("Ingrese la descripción de la tarea a consultar: ");
        string? descriptionInput = ReadLine();
        if (string.IsNullOrWhiteSpace(descriptionInput))
            throw new ArgumentException("La descripción no puede estar vacía.");
        List<Task> filteredTasks = Tasks.Where(t => t.Description.Contains(descriptionInput, StringComparison.OrdinalIgnoreCase)).ToList();
        ForegroundColor = ConsoleColor.Green;
        if (filteredTasks.Count == 0)
        {
            WriteLine("No se encontraron tareas que coincidan con la descripción proporcionada.");
            return Tasks;
        }
        WriteLine($"Tareas que contienen '{descriptionInput}' en la descripción:");
        foreach (var task in filteredTasks)
            WriteLine($"Id: {task.Id}, Descripción: {task.Description}, Estado: {(task.Completed ? "Completada" : "Pendiente")}");
      }catch (Exception ex){
        ForegroundColor = ConsoleColor.Red;
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Error al consultar la tarea por descripción: {ex.Message}");
      }
      return Tasks;
    }


    public List<Task> EditTask(){
      try {
        ResetColor();
        Clear();
        WriteLine("------Editar Tarea------");
        Write("Ingrese el Id de la tarea a editar: ");
        string? taskID = ReadLine();
        if (string.IsNullOrWhiteSpace(taskID))
            throw new ArgumentException("El Id de la tarea no puede estar vacío.");
        Task? task = Tasks.FirstOrDefault(t => t.Id.Equals(taskID));
        if (task == null)
            throw new ArgumentException("No se encontró una tarea con el Id proporcionado.");
        Write("Ingrese la nueva descripción de la tarea: ");
        string? newDescription = ReadLine();
        if (string.IsNullOrWhiteSpace(newDescription))
            throw new ArgumentException("La descripción de la tarea no puede estar vacía.");
        task.Description = newDescription;
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea editada exitosamente.");        

      }catch (Exception ex){
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Error al editar la tarea: {ex.Message}");
      }
      
      return Tasks;
    }



    public List<Task> TasksByState(){
      try {
        ResetColor();
        Clear();
        WriteLine("------Consultar Tareas por Estado------");
        Write("Ingrese el estado de las tareas a consultar (completada/pendiente): ");
        string? stateInput = ReadLine();
        if (string.IsNullOrWhiteSpace(stateInput))
            throw new ArgumentException("El estado no puede estar vacío.");
        bool isCompleted;
        if (stateInput.Equals("completada", StringComparison.OrdinalIgnoreCase))
            isCompleted = true;
        else if (stateInput.Equals("pendiente", StringComparison.OrdinalIgnoreCase))
            isCompleted = false;
        else
            throw new ArgumentException("Estado inválido. Use 'completada' o 'pendiente'.");
        var filteredTasks = Tasks.Where(t => t.Completed == isCompleted).ToList();
        ForegroundColor = ConsoleColor.Green;
        WriteLine($"Tareas con estado '{stateInput}':");
        foreach (var task in filteredTasks)
            WriteLine($"Id: {task.Id}, Descripción: {task.Description}");

      }catch (Exception ex){        
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Error al consultar las tareas por estado: {ex.Message}");
      }
      return Tasks;
    }


    public List<Task> RemoveTask(){
      try {
        ResetColor();
        Clear();
        WriteLine("------Eliminar Tarea------");
        Write("Ingrese el Id de la tarea a eliminar: ");
        string? taskID = ReadLine();
        if (string.IsNullOrWhiteSpace(taskID))
            throw new ArgumentException("El Id de la tarea no puede estar vacío.");
        Task? task = Tasks.FirstOrDefault(t => t.Id.Equals(taskID));
        if (task == null)
            throw new ArgumentException("No se encontró una tarea con el Id proporcionado.");
        Tasks.Remove(task);
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea eliminada exitosamente.");
      }catch (Exception ex){
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Error al eliminar la tarea: {ex.Message}");
      }
      return Tasks;
    }


    public List<Task> AddTask(){
      
      try {
        ResetColor();
        Clear();
        WriteLine("------Agregar Nueva Tarea------");
        Write("Ingrese la descripción de la tarea: ");
        string? description = ReadLine();
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("La descripción de la tarea no puede estar vacía.");
        Task newTask = new Task(Utils.GenerateId(), description);        
        Tasks.Add(newTask);
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea agregada exitosamente.");
        return Tasks;
      }catch (Exception ex){
        ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Error al agregar la tarea: {ex.Message}");
        return Tasks;
      }
   

    }


    public List<Task> MarkAsCompleted(){
   try {
        ResetColor();
        Clear();
        Console.WriteLine("------Marcar Tarea como Completada------");
        Console.WriteLine("Ingrese el Id de la tarea a marcar como completada: ");
        string? taskID = ReadLine();
        if (string.IsNullOrWhiteSpace(taskID)){           
          throw new ArgumentException("El Id de la tarea no puede estar vacío.");
        }            
        Task? task = Tasks.FirstOrDefault(t => t.Id.Equals(taskID));

        if (task == null) {        
         throw new ArgumentException("No se encontró una tarea con el Id proporcionado.");          
        }            

        task.Completed = true;
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea marcada como completada exitosamente.");
        return Tasks;
      }catch (Exception ex){
        ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Error al marcar la tarea como completada: {ex.Message}");
        return Tasks;
      }
    
    }



       
}


}



