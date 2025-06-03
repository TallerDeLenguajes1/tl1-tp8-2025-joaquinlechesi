// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using tarea;

List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();

int opcion, tareaID = 0, duracion;
string descripcion;

for (int i = 0; i < 3; i++)
{
        tareaID++;
        // descripcion = Console.ReadLine();
        // int.TryParse(Console.ReadLine(), out duracion);
        Tarea nuevaTarea = new Tarea(tareaID, "Tarea numero " + (i + 1));
        tareasPendientes.Add(nuevaTarea);
}

do
{
    Console.WriteLine("Ingrese una opcion:");
    int.TryParse(Console.ReadLine(), out opcion);
    switch (opcion)
    {
        // case 1: // crear tareas
        //     // int.TryParse(Console.ReadLine(), out tareaID);
        //     // tareaID = Console.ReadLine();
        //     tareaID++;
        //     descripcion = Console.ReadLine();
        //     int.TryParse(Console.ReadLine(), out duracion);
        //     Tarea nuevaTarea = new Tarea(tareaID, descripcion, duracion);
        //     tareasPendientes.Add(nuevaTarea);
        //     break;
        case 1: // mover tareas
            Console.WriteLine("Ingrese el ID de la tarea que desea marcar como realizada.");
            int.TryParse(Console.ReadLine(), out tareaID);
            for (int i = 0; i < tareasPendientes.Count; i++)
            {
                if (tareasPendientes[i].TareaID == tareaID)
                {
                    tareasRealizadas.Add(tareasPendientes[i]);

                }
            }
            break;
        case 3:
            for (int i = 0; i < tareasPendientes.Count; i++)
            {
                Console.WriteLine("ID:" + tareasPendientes[i].TareaID + ", Descripcion:" + tareasPendientes[i].Descripcion);
            }
            break;
        default:
            if (opcion != 0)
            {
                Console.WriteLine("No hay una opcion para el numero ingresado:");
            }
            break;
    }
} while (opcion != 0);