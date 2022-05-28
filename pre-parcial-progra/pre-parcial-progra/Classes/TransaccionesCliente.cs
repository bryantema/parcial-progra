using pre_parcial_progra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pre_parcial_progra.Classes
{
    public class OperacionesCliente : ITransaccionesClientes, IDescuentosCliente
    {
        public double calculoAhorro(Clientes cliente)
        {
            throw new NotImplementedException();
        }

        public double calculoISR(Clientes cliente)
        {
            double ISR;

            if (cliente.cantidaddonacion <= 30000.00)
            {
                ISR = cliente.cantidaddonacion * 0.05;
            }
            else
            {
                ISR = cliente.cantidaddonacion * 0.07;
            }

            return ISR;
        }

        public double calculoIVA(Clientes cliente)
        {
            throw new NotImplementedException();
        }

        public void crear(Clientes cliente)
        {
            throw new NotImplementedException();
        }

        public void editar(Clientes cliente)
        {
            throw new NotImplementedException();
        }

        public void eliminar(Clientes cliente)
        {
            throw new NotImplementedException();
        }
    }
}
