using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static GuiaDidactica_No2_AlexanderZelaya.Program;
using static System.Console;

namespace GuiaDidactica_No2_AlexanderZelaya
{
    internal class Program : Venta
    {
        static void Main(string[] args)
        {
            Venta venta = new Venta();
            while (true)
            {
                Clear();

                Write("==============================\n" +
                      "Bienvenido a Inmobilaria Sanz!\n" +
                      "\n" +
                      "Seleccione una opción:\n" +
                      "1. Registrar compra de cliente\n" +
                      "0. Salir de la aplicación\n" +
                      "==============================\n" +
                      "opción: ");
                int opc = Convert.ToInt32(ReadLine());

                if (opc == 1)
                {
                    venta.GenerarVenta();
                }
                else
                    if (opc == 0)
                {
                    Clear();
                    WriteLine("==============================\n" +
                              "      Hasta la próxima!\n" +
                              "==============================");
                    ReadKey();
                    break;
                }
                else
                    if (opc >= 2)
                {
                    Clear();
                    WriteLine("==============================\n" +
                              "  Ingrese una opción válida\n" +
                              "==============================");
                    return;
                }
            }
        }
    }
}
