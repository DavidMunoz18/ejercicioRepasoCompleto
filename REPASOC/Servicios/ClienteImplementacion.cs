using REPASOC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASOC.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {
        public void accesoCliente(List<ClienteDto> listaClientes)
        {
            Console.WriteLine("Introduzca el email");
            string emailRegistro = Console.ReadLine();

            Console.WriteLine("Introduzca la contraseña");
            string contraseniaRegistro = Console.ReadLine();

            foreach(ClienteDto cliente in listaClientes)
            {
                if (cliente.EmailCliente.Equals(emailRegistro) && cliente.EsValidado == true) 
                {
                    Console.WriteLine("HA INICIADO SESION CORRECTAMENTE");
                }
                else
                {
                    Console.WriteLine("NO SE PUEDE INICIAR SESION");
                }
            }
        }

        public void aniadirCliente(List<ClienteDto> listaClientes)
        {
            ClienteDto cliente = implementarCliente(listaClientes);

            listaClientes.Add(cliente);
        }
        private ClienteDto implementarCliente(List<ClienteDto> listaClientes)
        {

            
            ClienteDto cliente = new ClienteDto();

             manejarId(listaClientes);

            Console.WriteLine("Introduzca el dni");
            cliente.DniCliente = Console.ReadLine();

            Console.WriteLine("Introduzca el nombre completo");
            cliente.NombreCompletoCliente = Console.ReadLine();

            Console.WriteLine("Introduzca el email");
            cliente.EmailCliente = Console.ReadLine();

            Console.WriteLine("Introduzca la contraseña");
            cliente.ContraseniaCliente = Console.ReadLine();


            return cliente;

        }

        private void manejarId(List<ClienteDto> listaClientes)
        {
            ClienteDto cliente = new ClienteDto();

            long idCalculado;
            int tamanioLista = listaClientes.Count();

            if(tamanioLista == 0)
            {
                cliente.IdCliente = 1;
            }
            else
            {
                idCalculado = listaClientes[tamanioLista - 1].IdCliente + 1;
            }
        }
    }
}
