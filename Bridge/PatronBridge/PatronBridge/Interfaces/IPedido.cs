using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBridge.Interfaces
{
    public interface IEnviarPedido
    {
        void EnviarPedido();
        void EntregarPedido();
        void RecogerPedido();
    }
}
