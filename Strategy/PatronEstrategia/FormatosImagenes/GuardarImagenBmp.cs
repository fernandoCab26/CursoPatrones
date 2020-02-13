using PatronEstrategia.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronEstrategia.FormatosImagenes
{
    public class GuardarImagenBmp : BaseGuardarImagen, IGuardarImagen
    {
        public string Guardar(string nombre)
        {
            return CrearImagen(nombre, "BMP");
        }
    }
}
