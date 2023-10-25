using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = menuPrincipal();
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = menuPrincipal();
                        break;
                    case 1:
                        opcion = mPhone();
                        break;
                    case 2:
                        opcion = mPad();
                        break;
                    case 3:
                        opcion = MAPBrook();
                        break;
                    case 4:
                        opcion = mWatch();
                        break;
                }
            } while (opcion != 5);
        }

        private static int menuPrincipal()
        {
            Console.Clear();
            Console.Write("" +
                            "=========================\n" +
                            "Productos de mPhone\n" +
                            "=========================\n" +
                            "1: Ventas de mPhone 3000\n" +
                            "2: Ventas de mPad 3500\n" +
                            "3: Ventas de MAPBrook 3800\n" +
                            "4: Ventas de mWatch 8000\n" +
                            "5: Salir\n" +
                            "=========================\n" +
                            "Ingrese una opción: ");

            return getOpcion();

        }

        private static int getOpcion()
        {
            string opcionTexto = Console.ReadLine();
            return int.Parse(opcionTexto);
        }

        private static int mPhone()
        {
            Console.Clear();
            Console.Write("" +
                           "============================\n" +
                           "Registro Venta de mPhone 3000\n" +
                           "============================\n" +
                           "1: Registrar Venta\n" +
                           "2: Registrar Devolución\n" +
                           "3: Menu Principal\n" +
                           "===========================\n" +
                           "Ingrese una opción: ");
            int opcion = getOpcion();
            if (opcion ==1) return Venta1();
            if (opcion == 2) return Devolucion1();
            if (opcion ==3) return 0;
            return opcion;
        }
        private static int mPad()
        {
            Console.Clear();
            Console.Write("" +
                          "===============================\n" +
                          "Registrar Venta de mPad 3500\n" +
                          "===============================\n" +
                          "1: Registrar Venta\n" +
                          "2: Registrar Devolucion\n" +
                          "3: Menu Principal\n" +
                          "Ingrese una opcion: ");

            int opcion = getOpcion();
            if (opcion == 1) return Venta2();
            if (opcion == 2) return Devolucion2();
            if (opcion == 3) return 0;
            return opcion;

        }
        private static int MAPBrook()
        {
            Console.Clear();
            Console.Write("" +
                          "=============================\n" +
                          "Registrar Venta de mWatch 3800\n" +
                          "=============================\n" +
                          "1: Registrar Venta\n" +
                          "2: Registrar Devolucion\n" +
                          "3: Menu Principal\n" +
                          "=============================\n" +
                          "Ingrese una opcion: " );

            int opcion = getOpcion();
            if (opcion == 1) return Venta3();
            if (opcion == 2) return Devolucion3();
            if (opcion == 3) return 0;
            return opcion;
        }
        private static int mWatch()
        {
            Console.Clear();
            Console.Write("" +
                          "=============================\n" +
                          "Registrar Venta de mWatch 8000\n" +
                          "=============================\n" +
                          "1: Registrar Venta\n" +
                          "2: Registrar Devolucion\n" +
                          "3: Menu Principal\n" +
                          "=============================\n" +
                          "Ingrese una opcion: ");
            int opcion = getOpcion();
            if (opcion == 1) return Venta4();
            if (opcion == 2) return Devolucion4();
            if (opcion == 3) return 0;
            return opcion;
        }
        private static int Venta1()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la venta de un mPhone 3000 ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");

            return getOpcion();
        }
        private static int Devolucion1()
        {
            Console.Clear();
            Console.WriteLine("================================ ");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la devolución de un mPhone 3000 ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No ");
            Console.WriteLine("================================ ");
            Console.WriteLine("Ingrese una opción:");

            return getOpcion();
        }
        private static int Venta2()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la venta de un mPad 3500  ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");

            return getOpcion();
        }
        private static int Devolucion2()
        {
            Console.Clear();
            Console.WriteLine("================================ ");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la devolución de un mPad 3500 ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No ");
            Console.WriteLine("================================ ");
            Console.WriteLine("Ingrese una opción:");

            return getOpcion();
        }
        private static int Venta3()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la venta de un MAPBrook 3800 ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");

            return getOpcion();
        }
        private static int Devolucion3()
        {
            Console.Clear();
            Console.WriteLine("================================ ");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la devolución de un MAPBrook 3800 ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No ");
            Console.WriteLine("================================ ");
            Console.WriteLine("Ingrese una opción:");

            return getOpcion();
        }
        private static int Venta4()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la venta de un mWatch 8000 ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");

            return getOpcion();
        }
        private static int Devolucion4()
        {
            Console.Clear();
            Console.WriteLine("================================ ");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la devolución de un mWatch 8000 ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No ");
            Console.WriteLine("================================ ");
            Console.WriteLine("Ingrese una opción:");

            return getOpcion();
        }
        private static int estadistica()
        {
            Console.Clear();
            int VentasMPhone = 0;
            int VentasMPad = 0;
            int VentasMAPBrook = 0;
            int VentasMWatch = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Productos de mPhone");
                Console.WriteLine("================================");
                Console.WriteLine("1: Ventas de mPhone 3000");
                Console.WriteLine("2: Ventas de mPad 3500");
                Console.WriteLine("3: Ventas de MAPBrook 3800");
                Console.WriteLine("4: Ventas de mWatch 8000");
                Console.WriteLine("5: Salir");
                Console.WriteLine("================================");
                Console.Write("Ingrese una opción: ");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            VentasMPhone++;
                            break;
                        case 2:
                            VentasMPad++;
                            break;
                        case 3:
                            VentasMAPBrook++;
                            break;
                        case 4:
                            VentasMWatch++;
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("================================");
                            Console.WriteLine("Reporte Final");
                            Console.WriteLine("================================");
                            Console.WriteLine("Productos Vendidos | Cantidad");
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("mPhones | " + VentasMPhone);
                            Console.WriteLine("mPads | " + VentasMPad);
                            Console.WriteLine("MAPBrooks | " + VentasMAPBrook);
                            Console.WriteLine("mWatches | " + VentasMWatch);
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("Total | " + (VentasMPhone + VentasMPad + VentasMAPBrook + VentasMWatch));
                            Console.WriteLine("================================");
                            Console.WriteLine("¡Hasta Luego!");
                            Console.WriteLine("Diseñado Por: [Lorena Bnaces]");

                            return getOpcion();
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }                         
            }                  
        }
    }  
}
  