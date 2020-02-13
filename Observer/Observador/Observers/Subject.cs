using Observador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observador.Observers
{
    public class Subject : ISubject
    {
        private readonly List<IObserver> _subscripciones = new List<IObserver>();
        public void AgregarObserver(IObserver observer)
        {
            _subscripciones.Add(observer);
        }

        public void NotificarObserver()
        {
            foreach (var eventos in _subscripciones)
            {
                eventos.EjecutarAccion();
            }
        }
    }
}
