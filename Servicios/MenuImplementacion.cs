using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmetica.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Metodo que nos mostarara la calculadora y 
        /// </summary>
        /// <returns> ? </returns>
        public int mostrarCalculadoraYResultado()
        {
            int Seleccion;

            Console.WriteLine("#################");
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("1. Cerrar");
            Console.WriteLine("2. Suma");
            Console.WriteLine("3. Resta");
            Console.WriteLine("4. Multiplicación");
            Console.WriteLine("5. División");

            Seleccion = Console.ReadKey(true).KeyChar -('0');

            return Seleccion;

        }


        /*
        public int dameNumero()
        {
            Console.WriteLine("Dame un numero");
            int numeroDadoN = Convert.ToInt32(Console.ReadLine());
            return numeroDadoN;
        }
        */


        public int suma()
        {
            int n1;
            int n2;

            Console.WriteLine("Numero1");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Numero2");
            n2 = Int32.Parse(Console.ReadLine());

            int suma = n1 + n2;
            Console.WriteLine("Resultado: " + suma);

            return suma;
        }
    }
}
