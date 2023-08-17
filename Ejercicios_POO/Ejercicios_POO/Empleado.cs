public class Empleado
{
    private string nombre;
    private double sueldo;

    public Empleado()
    {
        Console.WriteLine("Introduce el nombre del empleado:");
        nombre = Console.ReadLine();

        Console.WriteLine("Introduce el sueldo del empleado:");
        sueldo = double.Parse(Console.ReadLine());
    }

    public void ImprimirDatos()
    {
        Console.WriteLine($"Nombre del empleado: {nombre}");
        Console.WriteLine($"Sueldo del empleado: {sueldo}");
    }

    public void DebePagarImpuestos()
    {
        if (sueldo > 3000)
        {
            Console.WriteLine($"{nombre} debe pagar impuestos.");
        }
        else
        {
            Console.WriteLine($"{nombre} no debe pagar impuestos.");
        }
    }
}