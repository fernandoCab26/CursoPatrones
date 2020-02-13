using Observador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observador.Observers
{
    public class CompiladorObserver : IObserver
    {
        public void EjecutarAccion()
        {
           Console.WriteLine("Compilación de código correcta");
        }
    }
}
