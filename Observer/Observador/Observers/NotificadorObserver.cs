using Observador.Interfaces;
using System;

namespace Observador.Observers
{
    public class NotificadorObserver : IObserver
    {
        public void EjecutarAccion()
        {
            Console.WriteLine( "Existe una actualización de código: versión 1.1");
        }
    }
}
