using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repaso220124.Dtos;

namespace Repaso220124.Servicios
{
    internal interface EmpleadoInterfaz
    {

        public void validarCliente(List<ClienteDto> listaClientes);
        public void borrarCliente(List<ClienteDto> listaClientes);
        public void mostrarClientes(List<ClienteDto> listaClientes);

    }
}
