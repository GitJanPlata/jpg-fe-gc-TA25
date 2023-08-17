public class Alumno
{
    private string nombre;
    private int edad;

    public Alumno()
    {
        Console.WriteLine("Introduce el nombre del alumno:");
        nombre = Console.ReadLine();

        Console.WriteLine("Introduce la edad del alumno:");
        edad = int.Parse(Console.ReadLine());
    }

    public void ImprimirDatos()
    {
        Console.WriteLine($"Nombre del alumno: {nombre}");
        Console.WriteLine($"Edad del alumno: {edad}");
    }

    public void EsMayorDeEdad()
    {
        if (edad >= 18)
        {
            Console.WriteLine($"{nombre} es mayor de edad.");
        }
        else
        {
            Console.WriteLine($"{nombre} no es mayor de edad.");
        }
    }
}

