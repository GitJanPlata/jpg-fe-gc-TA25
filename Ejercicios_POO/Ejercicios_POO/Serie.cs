using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO
{
    public class Serie
    {
        private string titulo;
        private int numeroDeTemporadas;
        private bool entregado;
        private string genero;
        private string creador;

        private const int NUMERO_TEMPORADAS_DEFAULT = 3;
        private const bool ENTREGADO_DEFAULT = false;

        // Constructor por defecto
        public Serie()
        {
            titulo = string.Empty;
            numeroDeTemporadas = NUMERO_TEMPORADAS_DEFAULT;
            entregado = ENTREGADO_DEFAULT;
            genero = string.Empty;
            creador = string.Empty;
        }

        // Constructor con título y creador; el resto por defecto
        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            numeroDeTemporadas = NUMERO_TEMPORADAS_DEFAULT;
            entregado = ENTREGADO_DEFAULT;
            genero = string.Empty;
            this.creador = creador;
        }

        // Constructor con todos los atributos, excepto entregado
        public Serie(string titulo, int numeroDeTemporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.numeroDeTemporadas = numeroDeTemporadas;
            this.entregado = ENTREGADO_DEFAULT;
            this.genero = genero;
            this.creador = creador;
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int NumeroDeTemporadas
        {
            get { return numeroDeTemporadas; }
            set { numeroDeTemporadas = value; }
        }

        public bool Entregado
        {
            get { return entregado; }
            set { entregado = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Creador
        {
            get { return creador; }
            set { creador = value; }
        }
    }

    // Ejemplo de uso
    public class MainSerie
    {
        public static void Main()
        {
            Serie s1 = new Serie();
            Serie s2 = new Serie("Breaking Bad", "Vince Gilligan");
            Serie s3 = new Serie("Stranger Things", 3, "Sci-Fi", "The Duffer Brothers");

            // Mostrar información de las series
            Console.WriteLine($"Titulo: {s1.Titulo}, Temporadas: {s1.NumeroDeTemporadas}, Entregado: {s1.Entregado}, Genero: {s1.Genero}, Creador: {s1.Creador}");
            Console.WriteLine($"Titulo: {s2.Titulo}, Temporadas: {s2.NumeroDeTemporadas}, Entregado: {s2.Entregado}, Genero: {s2.Genero}, Creador: {s2.Creador}");
            Console.WriteLine($"Titulo: {s3.Titulo}, Temporadas: {s3.NumeroDeTemporadas}, Entregado: {s3.Entregado}, Genero: {s3.Genero}, Creador: {s3.Creador}");
        }
    }

}
