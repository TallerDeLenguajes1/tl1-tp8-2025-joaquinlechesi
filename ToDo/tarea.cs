namespace tarea;

public class Tarea
{
    private int tareaID;
    private string descripcion;
    private int duracion;
    public Tarea(int tareaID, string descripcion)
    {
        this.tareaID = tareaID;
        this.descripcion = descripcion;
        // this.duracion = duracion;
    }
    public int TareaID { get => tareaID; set => tareaID = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }

}