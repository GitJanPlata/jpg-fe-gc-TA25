using Ejercicios_POO;


namespace Ejercicios_POO
{
    public class Persona
    {
        private string nombre;

        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {nombre}");
        }
    }
}

class PruebaPersona
{
    static void Main(string[] args)
    {
        Persona persona1 = new Persona();
        persona1.SetNombre("Jan");
        persona1.Saludar();

        Persona persona2 = new Persona();
        persona2.SetNombre("Desiree");
        persona2.Saludar();

        Console.ReadKey(); 
    }
}
