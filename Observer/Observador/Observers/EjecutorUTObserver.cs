using Observador.Interfaces;
using System;

namespace Observador.Observers
{
    public class EjecutorUTObserver : IObserver
    {
        public void EjecutarAccion()
        {
            Console.WriteLine("Todas las pruebas unitarias fueron exitosas");
        }
    }
}
