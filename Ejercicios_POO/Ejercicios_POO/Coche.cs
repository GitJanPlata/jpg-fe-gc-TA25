using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO
{
    public class Coche
    {
        private string marca;
        private string modelo;
        private int cilindrada;
        private double potencia;

        public string GetMarca()
        {
            return marca;
        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public string GetModelo()
        {
            return modelo;
        }

        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public int GetCilindrada()
        {
            return cilindrada;
        }

        public void SetCilindrada(int cilindrada)
        {
            this.cilindrada = cilindrada;
        }

        public double GetPotencia()
        {
            return potencia;
        }

        public void SetPotencia(double potencia)
        {
            this.potencia = potencia;
        }

        public static void Main(string[] args)
        {
            Coche coche1 = new Coche();  

            coche1.SetMarca("Toyota");
            coche1.SetModelo("Corolla");
            coche1.SetCilindrada(1800);
            coche1.SetPotencia(132.5);

            Console.WriteLine($"Marca: {coche1.GetMarca()}");
            Console.WriteLine($"Modelo: {coche1.GetModelo()}");
            Console.WriteLine($"Cilindrada: {coche1.GetCilindrada()} cc");
            Console.WriteLine($"Potencia: {coche1.GetPotencia()} HP");

            Console.ReadKey(); 
        }
    }
}
