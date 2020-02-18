using PatronDecorador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronDecorador
{
    public class EnviarCorreoService : CuentaxPagarDecorator
    {
        private readonly ICuentaxPagarService _cuentaxPagarService;

        public EnviarCorreoService(ICuentaxPagarService cuentaxPagarService)
        {
            _cuentaxPagarService = cuentaxPagarService;
        }
        public override void GuardarCxp()
        {
            _cuentaxPagarService.GuardarCxp();
            EnviarCorreo();
        }

        public void EnviarCorreo()
        {
            Console.WriteLine("Se ha enviado el correo al usuario");
        }
    }
}
