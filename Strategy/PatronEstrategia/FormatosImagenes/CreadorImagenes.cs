using PatronEstrategia.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronEstrategia.FormatosImagenes
{
    public class CreadorImagenes
    {
        private  IGuardarImagen _guardarImagen;

        public void SetCreadorImagenes(IGuardarImagen guardarImagen)
        {
            _guardarImagen = guardarImagen;
        }

        public string GuardarImagen(string nombre)
        {
            return _guardarImagen.Guardar(nombre);
        }
    }
}
