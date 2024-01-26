using REPASOC.Dtos;
using REPASOC.Servicios;

namespace REPASOC.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz ci = new ClienteImplementacion();   
            EmpleadoInterfaz ei = new EmpleadoImplementacion();

            int opcionMenu;
            bool cerrarMenu = false;
            while (!cerrarMenu)
            {
                opcionMenu = mi.mostrarMenuYSeleccion();
                switch (opcionMenu)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        int opcionEmpleado = mi.mostrarMenuEmpleado();
                        switch (opcionEmpleado)
                        {
                            case 1:
                                ei.validarCliente(listaClientes);
                                break;
                            case 2:
                                ei.borrarCliente(listaClientes);
                                break;
                            case 3:
                                ei.mostrarCliente(listaClientes);
                                break;
                        }

                        break;
                    case 2:
                        int opcionCliente = mi.mostrarMenuCliente();
                        switch (opcionCliente)
                        {
                            case 1:
                                ci.aniadirCliente(listaClientes);
                                break;
                            case 2:
                                ci.accesoCliente(listaClientes);
                                break;
                        }

                        break;

                    default:
                        Console.WriteLine("La opcion escogida no existe");
                        break;
                }
            }
        }
    }
}
