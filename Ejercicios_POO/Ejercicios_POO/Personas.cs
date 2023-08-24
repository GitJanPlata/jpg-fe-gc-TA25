using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO
{
    public class Personas
    {
        public const char SEXO_HOMBRE = 'H';
        public const char SEXO_MUJER = 'M';

        private string nombre;
        private int edad;
        private string dni;
        private char sexo;
        private double peso;
        private double altura;

        // Constructor por defecto
        public Personas()
        {
            this.nombre = "";
            this.edad = 0;
            this.dni = "";
            this.sexo = SEXO_HOMBRE;
            this.peso = 0.0;
            this.altura = 0.0;
        }

        // Constructor con nombre, edad y sexo; el resto por defecto
        public Personas(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = "";
            this.sexo = sexo;
            this.peso = 0.0;
            this.altura = 0.0;
        }

        // Constructor con todos los atributos
        public Personas(string nombre, int edad, string dni, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni; 
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string DNI
        {
            get { return dni; }
            set { dni = value; } 
        }

        public char Sexo
        {
            get { return sexo; }
            set
            {
                if (value == SEXO_HOMBRE || value == SEXO_MUJER)
                    sexo = value;
                else
                    throw new ArgumentException("Sexo inválido. Debe ser 'H' o 'M'.");
            }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

    }

}
