using PatronDecorador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronDecorador
{
    public class CuentaxPagarService : ICuentaxPagarService
    {
        public void GuardarCxp()
        {
            Console.WriteLine("Se ha guardado la CxP");
        }
    }
}
