using PatronDecorador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronDecorador
{
    public abstract class CuentaxPagarDecorator : ICuentaxPagarService
    {
        public abstract void GuardarCxp();

    }
}
