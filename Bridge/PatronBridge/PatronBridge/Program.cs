using PatronBridge.Envios;
using PatronBridge.Interfaces;
using System;

namespace PatronBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Crear la empresa fedex que enviara un pedido por mar.
            //• Crear la empresa DHL que enviara un pedido por aire y otro por barco
            //• Crear la empresa Estafeta que enviara un pedido por tren
            IEnviarPedido envioBarco = new EnvioBarco();
            IEnviarPedido enviarAvion = new EnvioAvion();
            IEnviarPedido enviarTren = new EnvioTren();

            Console.WriteLine("Enviando por Fedex");
            Mensajeria fedex = new Fedex();

            fedex.SetMedioTransporte(envioBarco);
            fedex.RecogerPedido();
            fedex.EnviarPedido();
            fedex.EntregarPedido();

            Console.WriteLine("Enviando por DHL");
            Mensajeria dhl = new Dhl();

            dhl.SetMedioTransporte(enviarAvion);
            dhl.RecogerPedido();
            dhl.EnviarPedido();
            dhl.EntregarPedido();

            dhl.SetMedioTransporte(envioBarco);
            dhl.RecogerPedido();
            dhl.EnviarPedido();
            dhl.EntregarPedido();

            Console.WriteLine("Enviando por Estafeta");
            Mensajeria estafeta = new Estafeta();
            estafeta.SetMedioTransporte(enviarTren);
            estafeta.RecogerPedido();
            estafeta.EnviarPedido();
            estafeta.EntregarPedido();
        }
    }
}
