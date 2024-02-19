using Repaso220124.Servicios;

namespace Repaso220124
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();

            int opcionPrincipal;
            bool cerrarPrincipal = false;

            do
            {
                Console.WriteLine("MENÚ INICIAL");
                opcionPrincipal = mi.mostrarMenuPrincipalYSeleccion();
                switch (opcionPrincipal){

                    case 0:
                        Console.WriteLine("Se cierra la aplicación");
                        cerrarPrincipal = true;
                        break;
                    case 1:
                        Console.WriteLine("VERSIÓN EMPLEADO");
                        mi.accederVersionEmpleado();
                        
                        break;
                    case 2:
                        Console.WriteLine("VERSIÓN CLIENTE");
                        mi.accederVersionCliente();                        
                        break;
                    default:
                        Console.WriteLine("No se ha elegido una opción aceptable");
                        break;
                }

            } while (!cerrarPrincipal);
        }
    }
}
