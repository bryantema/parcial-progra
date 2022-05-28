using pre_parcial_progra.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pre_parcial_progra.Interfaces
{
        interface ICrearClientes
        {
            void crear(Clientes cliente);
        }

        interface IEditarClientes
        {
            void editar(Clientes cliente);
        }

        interface IEliminarClientes
        {
            void eliminar(Clientes cliente);
        }

        interface ITransaccionesClientes : ICrearClientes, IEditarClientes, IEliminarClientes
        {

        }
}
