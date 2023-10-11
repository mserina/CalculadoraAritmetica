using CalculadoraAritmetica.Servicios;

namespace CalculadoraAritmetica
{
    /// <summary>
    /// Clase principal
    /// 101023 - msm
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo main, donde se define el orden de los metodos
        /// 101023 - msm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Variables
            int OpcionSeleccionada;
            bool cerrarCalculadora = false;
            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();



           //prodecimiento
            while (!cerrarCalculadora) { 
                
                OpcionSeleccionada = mi.mostrarCalculadoraYResultado();

                switch (OpcionSeleccionada)
                {
                    case 1:
                        Console.WriteLine("Cerrando Calculadora");
                        cerrarCalculadora = true;
                        break;
                    case 2:
                        Console.WriteLine("2");
                        Console.WriteLine("Ha seleccionado la operacion Suma");
                        op.suma();
                        break;
                    case 3:
                        Console.WriteLine("3");
                        Console.WriteLine("Ha seleccionado la operacion Resta");
                        op.resta();
                        break;
                    case 4:
                        Console.WriteLine("4");
                        Console.WriteLine("Ha seleccionado la operacion Multiplicacion");
                        op.multiplicacion();
                        break;
                    case 5:
                        Console.WriteLine("5");
                        Console.WriteLine("Ha seleccionado la operacion Division");
                        op.division();
                        break;
                }

            }

        }

    }

}

