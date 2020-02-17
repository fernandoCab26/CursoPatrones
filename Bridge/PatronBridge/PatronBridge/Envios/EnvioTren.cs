using PatronBridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBridge.Envios
{
    public class EnvioTren : IEnviarPedido
    {
        public void EntregarPedido()
        {
            Console.WriteLine("Se ha descargado el pedido pr tren");
        }

        public void EnviarPedido()
        {
            Console.WriteLine("Se ha enviado el paquete por tren");
        }

        public void RecogerPedido()
        {
            Console.WriteLine("Se ha cargado el pedido al tren");
        }
    }
}
