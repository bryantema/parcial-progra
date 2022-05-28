using pre_parcial_progra.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pre_parcial_progra.Interfaces
{


    interface IISR
    {
        double calculoISR(Clientes cliente);
    }

    interface IIVA
    {
        double calculoIVA(Clientes cliente);
    }

    interface IAhorros
    {
        double calculoAhorro(Clientes cliente);
    }

    interface IDescuentosCliente : IISR, IIVA, IAhorros
    {

    }
}
