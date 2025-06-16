namespace calculadora;

public class Calculadora
{
    private double dato = 0;
    // public int numero2;
    public double Dato
    {
        // get => dato;
        set => dato = value;
    }
    private List<Operacion> listaDeOperaciones = new List<Operacion>();
    public List<Operacion> ListaDeOperaciones
    {
        get => listaDeOperaciones;
    }
    public void Sumar(double termino)
    {
        Operacion nueva = new Operacion(dato, termino, TipoOperacion.Suma);
        dato = dato + termino;
        listaDeOperaciones.Add(nueva);
    }
    public void Restar(double termino)
    {
        Operacion nueva = new Operacion(dato, termino, TipoOperacion.Resta);
        dato = dato - termino;
        listaDeOperaciones.Add(nueva);
    }
    public void Multiplicar(double termino)
    {
        Operacion nueva = new Operacion(dato, termino, TipoOperacion.Multiplicacion);
        dato = dato * termino;
        listaDeOperaciones.Add(nueva);
    }
    public void Dividir(double termino)
    {
        Operacion nueva = new Operacion(dato, termino, TipoOperacion.Division);
        dato = dato / termino;
        listaDeOperaciones.Add(nueva);
        // if (termino == 0)
        // {
        //     dato = 0;
        // }else
        // {
        // }
    }
    public void Limpiar()
    {
        Operacion nueva = new Operacion(dato, 0, TipoOperacion.Limpiar);
        dato = 0;
        listaDeOperaciones.Add(nueva);
    }
    public double Resultado
    {
        get => dato;
    }
    //public void nuevaOperacion()
    //{
        // Operacion nuevaOperacion = new Operacion();
        // if (listaDeOperaciones.Count == 0)
        // {

        // }
        // else
        // {

        // }
    //}
}
public class Operacion
{
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion; // El tipo de opertacion
    public double Resultado()
    {
        double resultadoSalida;
        switch (operacion)
        {
            case TipoOperacion.Suma:
                resultadoSalida = resultadoAnterior + nuevoValor;
                break;
            case TipoOperacion.Resta:
                resultadoSalida = resultadoAnterior - nuevoValor;
                break;
            case TipoOperacion.Multiplicacion:
                resultadoSalida = resultadoAnterior * nuevoValor;
                break;
            case TipoOperacion.Division:
                resultadoSalida = resultadoAnterior / nuevoValor;
                break;
            default:
                resultadoSalida = 0;
                break;
        }
        return resultadoSalida;
    }
    public double NuevoValor
    {
        get => nuevoValor;
    }
    public TipoOperacion TipoOperacion
    {
        get => operacion;
    }
    public Operacion(double ResultadoAnterior, double NuevoValor_constructor, TipoOperacion Operacion)
    {
        this.resultadoAnterior = ResultadoAnterior;
        this.nuevoValor = NuevoValor_constructor;
        this.operacion = Operacion;
    }
}
public enum TipoOperacion
{
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar
}