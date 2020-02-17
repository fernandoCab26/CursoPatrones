using PatronBridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBridge
{
   public abstract class Mensajeria
    {
        private IEnviarPedido _pedido;

        public void SetMedioTransporte(IEnviarPedido pedido)
        {
            _pedido = pedido;
        }

        public void EnviarPedido()
        {
            _pedido.EnviarPedido();
        }

        public void EntregarPedido()
        {
            _pedido.EntregarPedido();
        }

        public void RecogerPedido()
        {
            _pedido.RecogerPedido();
        }
    }
}
