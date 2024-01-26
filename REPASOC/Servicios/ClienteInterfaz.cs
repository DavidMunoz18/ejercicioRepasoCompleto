using REPASOC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASOC.Servicios
{
    internal interface ClienteInterfaz
    {
        public void aniadirCliente(List<ClienteDto> listaClientes);

        public void accesoCliente(List<ClienteDto> listaClientes);
    }
}
