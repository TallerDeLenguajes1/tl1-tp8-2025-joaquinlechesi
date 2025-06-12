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
    List<Operacion> listaDeOperaciones;
    public void Sumar(double termino)
    {
        dato = dato + termino;
        Operacion nueva = new Operacion(dato, termino, TipoOperacion.Suma);
        listaDeOperaciones.Add(nueva);
    }
    public void Restar(double termino)
    {
        dato = dato - termino;
        Operacion nueva = new Operacion(dato, termino, TipoOperacion.Resta);
        listaDeOperaciones.Add(nueva);
    }
    public void Multiplicar(double termino)
    {
        dato = dato * termino;
        Operacion nueva = new Operacion(dato, termino, TipoOperacion.Multiplicacion);
        listaDeOperaciones.Add(nueva);
    }
    public void Dividir(double termino)
    {
        dato = dato / termino;
        Operacion nueva = new Operacion(dato, termino, TipoOperacion.Division);
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
        dato = 0;
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
        switch ((int)operacion)
        {
            case 1:
                resultadoSalida = resultadoAnterior + nuevoValor;
                break;
            case 2:
                resultadoSalida = resultadoAnterior - nuevoValor;
                break;
            case 3:
                resultadoSalida = resultadoAnterior * nuevoValor;
                break;
            case 4:
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