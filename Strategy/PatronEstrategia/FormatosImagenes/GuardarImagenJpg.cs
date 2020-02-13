using PatronEstrategia.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronEstrategia.FormatosImagenes
{
    public class GuardarImagenJpg : BaseGuardarImagen, IGuardarImagen
    {
        public string Guardar(string nombre)
        {
            return CrearImagen(nombre, "jpg");
        }
    }
}
