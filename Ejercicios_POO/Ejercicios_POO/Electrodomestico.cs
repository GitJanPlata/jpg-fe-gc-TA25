using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO
{
    public class Electrodomestico
    {
        // Constantes para los valores por defecto
        protected const double PRECIO_BASE_DEFAULT = 100;
        protected const string COLOR_DEFAULT = "blanco";
        protected const char CONSUMO_ENERGETICO_DEFAULT = 'F';
        protected const double PESO_DEFAULT = 5;

        // Atributos
        protected double precioBase;
        protected string color;
        protected char consumoEnergetico;
        protected double peso;

        // Constructor por defecto
        public Electrodomestico()
        {
            precioBase = PRECIO_BASE_DEFAULT;
            color = COLOR_DEFAULT;
            consumoEnergetico = CONSUMO_ENERGETICO_DEFAULT;
            peso = PESO_DEFAULT;
        }

        // Constructor con precio y peso; el resto por defecto
        public Electrodomestico(double precioBase, double peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            color = COLOR_DEFAULT;
            consumoEnergetico = CONSUMO_ENERGETICO_DEFAULT;
        }

        // Constructor con todos los atributos
        public Electrodomestico(double precioBase, string color, char consumoEnergetico, double peso)
        {
            this.precioBase = precioBase;
            SetColor(color);
            SetConsumoEnergetico(consumoEnergetico);
            this.peso = peso;
        }

        // Métodos para establecer color y consumo energético con validaciones
        private void SetColor(string color)
        {
            string[] coloresValidos = { "blanco", "negro", "rojo", "azul", "gris" };
            if (Array.Exists(coloresValidos, elemento => elemento.Equals(color, StringComparison.OrdinalIgnoreCase)))
            {
                this.color = color.ToLower(); 
            }
            else
            {
                this.color = COLOR_DEFAULT;
            }
        }

        private void SetConsumoEnergetico(char consumoEnergetico)
        {
            char[] consumosValidos = { 'A', 'B', 'C', 'D', 'E', 'F' };
            if (Array.Exists(consumosValidos, elemento => elemento == Char.ToUpper(consumoEnergetico)))
            {
                this.consumoEnergetico = Char.ToUpper(consumoEnergetico); 
            }
            else
            {
                this.consumoEnergetico = CONSUMO_ENERGETICO_DEFAULT;
            }
        }

        public double PrecioBase
        {
            get { return precioBase; }
            set { precioBase = value; }
        }

        public string Color
        {
            get { return color; }
            set { SetColor(value); }
        }

        public char ConsumoEnergetico
        {
            get { return consumoEnergetico; }
            set { SetConsumoEnergetico(value); }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
    }
    public class MainElectrodomestico
    {
        public static void Main()
        {
            Electrodomestico e1 = new Electrodomestico();
            Console.WriteLine($"Precio: {e1.PrecioBase}, Color: {e1.Color}, Consumo: {e1.ConsumoEnergetico}, Peso: {e1.Peso}");

            Electrodomestico e2 = new Electrodomestico(250, 8);
            Console.WriteLine($"Precio: {e2.PrecioBase}, Color: {e2.Color}, Consumo: {e2.ConsumoEnergetico}, Peso: {e2.Peso}");

            Electrodomestico e3 = new Electrodomestico(300, "rojo", 'A', 10);
            Console.WriteLine($"Precio: {e3.PrecioBase}, Color: {e3.Color}, Consumo: {e3.ConsumoEnergetico}, Peso: {e3.Peso}");
        }
    }
}
