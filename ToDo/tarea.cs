namespace tarea;

public class Tarea
{
    private int tareaID;
    private string descripcion;
    private int duracion;
    public Tarea(int TareaID_constructor, string Descripcion_constructor, int duracion_constructor)
    {
        this.TareaID = TareaID_constructor;
        this.Descripcion = Descripcion_constructor;
        this.Duracion = duracion_constructor;
    }
    public int TareaID { get => tareaID; set => tareaID = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }

}