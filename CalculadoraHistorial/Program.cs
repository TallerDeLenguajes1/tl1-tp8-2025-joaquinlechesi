using calculadora;
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("CALCULADORA:");
int opcion;
double termino, numero;
Console.WriteLine("Ingrese un numero para inicializar:");
double.TryParse(Console.ReadLine(), out numero);
Calculadora calculadora1 = new Calculadora();
calculadora1.Dato = numero;
do
{
    Console.WriteLine("OPCIONES:\n1 para Sumar\n2 para Restar\n3 para Multiplicar\n4 para Dividir\n5 para limpiar el numer ingresado");
    int.TryParse(Console.ReadLine(), out opcion);
    if (opcion != 0)
    {
        Console.WriteLine("Ingrese un numero:");
    }
    switch (opcion)
    {
        case 1:
            // Console.WriteLine("Ingrese un numero:");
            double.TryParse(Console.ReadLine(), out termino);
            calculadora1.Sumar(termino);
            // Console.WriteLine("RESULTADO: " + calculadora1.Resultado);
            break;
        case 2:
            // Console.WriteLine("Ingrese un numero:");
            double.TryParse(Console.ReadLine(), out termino);
            calculadora1.Restar(termino);
            // Console.WriteLine("RESULTADO: " + calculadora1.Resultado);
            break;
        case 3:
            // Console.WriteLine("Ingrese un numero:");
            double.TryParse(Console.ReadLine(), out termino);
            calculadora1.Multiplicar(termino);
            // Console.WriteLine("RESULTADO: " + calculadora1.Resultado);
            break;
        case 4:
            // Console.WriteLine("Ingrese un numero:");
            double.TryParse(Console.ReadLine(), out termino);
            if (termino == 0)
            {
                Console.WriteLine("No se puede realizar una divicion en 0.");
            }
            else
            {
                calculadora1.Dividir(termino);
            }
            // Console.WriteLine("RESULTADO: " + calculadora1.Resultado);
            break;
        case 5:
            calculadora1.Limpiar();
            break;
        default:
            break;
    }
    if (opcion != 0)
    {
        Console.WriteLine("Resultado de la operacion seleccionada: " + calculadora1.Resultado);
    }
} while (opcion != 0);

Console.WriteLine("Listado de operaciones:");
for (int i = 0; i < calculadora1.ListaDeOperaciones.Count; i++)
{
    Console.WriteLine("Operacion: " + calculadora1.ListaDeOperaciones[i].TipoOperacion);
    Console.WriteLine("Resultado: " + calculadora1.ListaDeOperaciones[i].Resultado());
}