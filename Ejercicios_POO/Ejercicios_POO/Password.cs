using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO
{
    public class Password
    {
        private int longitud;
        private string contraseña;

        private const int LONGITUD_DEFAULT = 8;

        // Constructor por defecto
        public Password()
        {
            this.longitud = LONGITUD_DEFAULT;
            this.contraseña = GenerarContraseña(this.longitud);
        }

        // Constructor con longitud
        public Password(int longitud)
        {
            this.longitud = longitud;
            this.contraseña = GenerarContraseña(this.longitud);
        }

        private string GenerarContraseña(int length)
        {
            const string caracteresValidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random random = new Random();

            return new string(Enumerable.Repeat(caracteresValidos, length)
                                        .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public int Longitud
        {
            get { return longitud; }
            set
            {
                longitud = value;
                contraseña = GenerarContraseña(longitud);  
            }
        }

        public string Contraseña
        {
            get { return contraseña; }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Password pwd1 = new Password();
            Console.WriteLine($"Contraseña (longitud por defecto): {pwd1.Contraseña}");

            Password pwd2 = new Password(15);
            Console.WriteLine($"Contraseña (15 caracteres): {pwd2.Contraseña}");
        }
    }
}
