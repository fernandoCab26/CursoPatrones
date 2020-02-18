using PatronDecorador.Interfaces;

namespace PatronDecorador
{
    class Program
    {
        static void Main(string[] args)
        {
            ICuentaxPagarService cuentaxPagarService = new CuentaxPagarService();
            CuentaxPagarDecorator cxpConHistorial = new GuardarHistorialCxpService(cuentaxPagarService);
            CuentaxPagarDecorator enviarCorreoCxp = new EnviarCorreoService(cxpConHistorial);
            enviarCorreoCxp.GuardarCxp();
        }
    }
}
