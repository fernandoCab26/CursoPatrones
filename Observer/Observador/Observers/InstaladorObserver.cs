using Observador.Interfaces;
using System;

namespace Observador.Observers
{
    public class InstaladorObserver : IObserver
    {
        public void EjecutarAccion()
        {
           Console.WriteLine("Se ha instalado la versión 1.1");
        }
    }
}
