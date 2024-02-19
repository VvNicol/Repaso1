using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repaso220124.Dtos;

namespace Repaso220124.Servicios
{
    internal interface ClienteInterfaz
    {

        public void registroNuevoCliente(List<ClienteDto> listaClientes);

        public void accesoCliente(List<ClienteDto> listaClientes);

    }
}
