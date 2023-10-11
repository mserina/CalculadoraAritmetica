using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmetica.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        private int cogerNumero()
        {
            Console.WriteLine("Dame numero");
            int numero = Int32.Parse(Console.ReadLine());
            return numero;
        }

        public int suma()
        {
            int n1 = cogerNumero();
            int n2 = cogerNumero();
            int suma = n1 + n2;
            Console.WriteLine("Resultado: " + suma);

            return suma;
        }

        public int resta()
        {
            int n1 = cogerNumero();
            int n2 = cogerNumero();
            int resta = n1 - n2;
            Console.WriteLine("Resultado: " + resta);

            return resta;
        }

        public int multiplicacion()
        {
            int n1 = cogerNumero();
            int n2 = cogerNumero();
            int mult = n1 * n2;
            Console.WriteLine("Resultado: " + mult);

            return mult;
        }

        public int division()
        {
            int n1 = cogerNumero();
            int n2 = cogerNumero();
            int div = n1 / n2;
            Console.WriteLine("Resultado: " + div);

            return div;
        }
    }
}     
