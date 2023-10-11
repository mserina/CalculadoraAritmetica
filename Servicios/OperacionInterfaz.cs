using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmetica.Servicios
{
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// Metodo que realiza la operacion suma
        /// 101023 - msm
        /// </summary>
        public int suma();

        /// <summary>
        /// Metodo que realiza la operacion resta
        /// 101023 - msm
        /// </summary>
        public int resta();

        /// <summary>
        /// Metodo que realiza la operacion multiplicacion
        /// 101023 - msm
        /// </summary>
        public int multiplicacion();

        /// <summary>
        /// Metodo que realiza la operacion division
        /// 101023 - msm
        /// </summary>
        public int division();
    }
}
