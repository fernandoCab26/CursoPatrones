using PatronDecorador.Interfaces;
using System;

namespace PatronDecorador
{
    public class GuardarHistorialCxpService : CuentaxPagarDecorator
    {
        private readonly ICuentaxPagarService _cuentaxPagarService;

        public GuardarHistorialCxpService(ICuentaxPagarService cuentaxPagarService)
        {
            _cuentaxPagarService = cuentaxPagarService;
        }
        public override void GuardarCxp()
        {
            _cuentaxPagarService.GuardarCxp();
            GuardarHistrorial();
        }

        public void GuardarHistrorial()
        {
            Console.WriteLine("Se ha guardado el historial de la cxp");
        }
    }
}
