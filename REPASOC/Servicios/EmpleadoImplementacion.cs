using REPASOC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASOC.Servicios
{
    internal class EmpleadoImplementacion : EmpleadoInterfaz
    {
        public void borrarCliente(List<ClienteDto> listaClientes)
        {

            

            if(listaClientes.Count > 0)
            {
                Console.WriteLine("Introduzca el dni del cliente a borrar");
                string dniClienteABorrar = Console.ReadLine();
                foreach (ClienteDto cliente in listaClientes)
                {
                    if (dniClienteABorrar.Equals(cliente.DniCliente))
                    {
                    listaClientes.Remove(cliente);
                    }
                 }
            }
            else
            {
                Console.WriteLine("No hay ningun cliente");
            }
            
        }

        public void mostrarCliente(List<ClienteDto> listaClientes)
        {
            if(listaClientes.Count >0)
            {
                foreach(ClienteDto cliente in listaClientes)
                {
                    if(cliente.EsValidado == true)
                    {
                        Console.WriteLine("\\\\\\\\\\\\\\\\\\\\");
                        Console.WriteLine("DNI: " + cliente.DniCliente);
                        Console.WriteLine("NOMBRE: " + cliente.NombreCompletoCliente);
                        Console.WriteLine("ESTADO VALIDACIÓN: si");
                        Console.WriteLine("\\\\\\\\\\\\\\\\\\\\");
                    }
                    else
                    {
                        Console.WriteLine("\\\\\\\\\\\\\\\\\\\\");
                        Console.WriteLine("DNI: " + cliente.DniCliente);
                        Console.WriteLine("NOMBRE: " + cliente.NombreCompletoCliente);
                        Console.WriteLine("ESTADO VALIDACIÓN: no");
                        Console.WriteLine("\\\\\\\\\\\\\\\\\\\\");
                    }
                }
           
            }
            else
            {
                Console.WriteLine("No hay clientes");
            }
        }

        public void validarCliente(List<ClienteDto> listaClientes)
        {
         
            

            if(listaClientes.Count > 0)
            {
                foreach(ClienteDto cliente in listaClientes)
                {
                    Console.WriteLine("Introduzca el dni del cliente a validar");
                    string dniCliente = Console.ReadLine();

                    Console.WriteLine("CLIENTES NO VALIDADOS");
                    Console.WriteLine("\\\\\\\\\\\\\\\\\\\\");
                    Console.WriteLine("DNI: " + cliente.DniCliente);
                    Console.WriteLine("NOMBRE: " + cliente.NombreCompletoCliente);
                    Console.WriteLine("\\\\\\\\\\\\\\\\\\\\");

               
                        if (dniCliente.Equals(cliente.DniCliente))
                        {
                            cliente.EsValidado = true;
                            Console.WriteLine("EL CLIENTE HA SIDO VALIDADO");
                        }
                        else
                        {
                            Console.WriteLine("EL DNI SELECCIONADO NO COINCIDE");
                            cliente.EsValidado = false;
                        }
                }
               
                


            }
            else
            {
                Console.WriteLine("No hay ningun cliente");
            }        
           
        }
        
    }
}
