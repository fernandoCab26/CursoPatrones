using Observador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observador.Observers
{
   public class SubirCodigoObserver : IObserver
    {
        public void EjecutarAccion()
        {
            Console.WriteLine("Codigo subido correctamente");
        }
    }
}
