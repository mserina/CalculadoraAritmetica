using CalculadoraAritmetica.Servicios;

namespace CalculadoraAritmetica
{
    /// <summary>
    /// Clase principal
    /// 101023 - msm
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int OpcionSeleccionada;
            bool cerrarCalculadora = false;
            MenuInterfaz mi = new MenuImplementacion();



           //prodecimiento
            while (!cerrarCalculadora) { 
                
                OpcionSeleccionada = mi.mostrarCalculadoraYResultado();

                switch (OpcionSeleccionada)
                {
                    case 1:
                        mi.suma();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                }

            }



        }

    }

}

