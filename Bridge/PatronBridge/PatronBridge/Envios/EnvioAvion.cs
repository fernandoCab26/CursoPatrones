using PatronBridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBridge.Envios
{
    public class EnvioAvion : IEnviarPedido
    {
        public void EntregarPedido()
        {
            Console.WriteLine("Se ha descargado el pedido pr avión");
        }

        public void EnviarPedido()
        {
            Console.WriteLine("Se ha enviado el paquete por avión");
        }

        public void RecogerPedido()
        {
            Console.WriteLine("Se ha cargado el pedido al avión");
        }
    }
}
