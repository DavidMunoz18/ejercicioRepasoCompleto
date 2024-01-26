using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASOC.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuCliente()
        {
            int opcionIntroducida;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Registro cliente");
            Console.WriteLine("2. Acceso cliente");
            Console.WriteLine("---------------------------------");
            opcionIntroducida = Convert.ToInt32(Console.ReadLine());    

            return opcionIntroducida;
           
        }

        public int mostrarMenuEmpleado()
        {
            int opcionIntroducida;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Validar cliente");
            Console.WriteLine("2. Borrado de cliente");
            Console.WriteLine("3. Mostrar cliente");
            Console.WriteLine("---------------------------------");
            opcionIntroducida = Convert.ToInt32(Console.ReadLine());

            return opcionIntroducida;

        }

        public int mostrarMenuYSeleccion()
        {
            

            int opcionIntroducida;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. VERSION EMPLEADO");
            Console.WriteLine("2. VERSION CLIENTE");
            Console.WriteLine("---------------------------------");
            opcionIntroducida = Convert.ToInt32(Console.ReadLine());
            return opcionIntroducida;

        }
    }
}
