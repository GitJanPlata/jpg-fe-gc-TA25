public class Operaciones
{
    private int valor1;
    private int valor2;

    public Operaciones(int v1, int v2)
    {
        valor1 = v1;
        valor2 = v2;
    }

    public int Sumar()
    {
        return valor1 + valor2;
    }

    public int Restar()
    {
        return valor1 - valor2;
    }

    public int Multiplicar()
    {
        return valor1 * valor2;
    }

    public double Dividir()
    {
        if (valor2 == 0)
        {
            throw new DivideByZeroException("No se puede dividir por cero.");
        }
        return (double)valor1 / valor2;
    }
    public void ImprimirResultados()
    {
        Console.WriteLine($"Suma: {Sumar()}");
        Console.WriteLine($"Resta: {Restar()}");
        Console.WriteLine($"Multiplicación: {Multiplicar()}");
        try
        {
            Console.WriteLine($"División: {Dividir()}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
