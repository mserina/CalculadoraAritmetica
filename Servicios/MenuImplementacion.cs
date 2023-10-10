using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmetica.Servicios
{
    /// <summary>
    /// Clase que implementa menuInterfaz con MenuImplementacion
    /// 101023 - msm
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
         
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
            Console.WriteLine("Elija una opcion: ");


            Seleccion = Console.ReadKey(true).KeyChar -('0');

            return Seleccion;

        }



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

        public int resta()
        {
            int n1;
            int n2;

            Console.WriteLine("Numero1");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Numero2");
            n2 = Int32.Parse(Console.ReadLine());

            int resta = n1 - n2;
            Console.WriteLine("Resultado: " + resta);

            return resta;
        }

        public int multiplicacion()
        {
            int n1;
            int n2;

            Console.WriteLine("Numero1");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Numero2");
            n2 = Int32.Parse(Console.ReadLine());

            int mult = n1 * n2;
            Console.WriteLine("Resultado: " + mult);

            return mult;
        }

        public int division()
        {
            int n1;
            int n2;

            Console.WriteLine("Numero1");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Numero2");
            n2 = Int32.Parse(Console.ReadLine());

            int div = n1 / n2;
            Console.WriteLine("Resultado: " + div);

            return div;
        }
    }
}
