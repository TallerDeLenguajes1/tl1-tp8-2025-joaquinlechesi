namespace tarea;

public static class Funciones
{
    public static void buscarTarea(List<Tarea> lista)
    {
        string cadenaSalida = "";
        string descripcion;
        Console.WriteLine("Ingrese la descripcion de la tarea que desea buscar:");
        descripcion = Console.ReadLine();
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].Descripcion.Contains(descripcion)) // Consultar si debo usarr String.Contains
            {
                cadenaSalida = $"ID: {lista[i].TareaID}\nDescripcion: {lista[i].Descripcion}\nDuracion {lista[i].Duracion}";
                Console.WriteLine(cadenaSalida);
            }
        }
        if (cadenaSalida == "")
        {
            Console.WriteLine("No hay tarea con esa descripcion.");
        }
    }
}