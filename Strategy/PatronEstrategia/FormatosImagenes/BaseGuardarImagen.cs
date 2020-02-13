using System;
using System.Collections.Generic;
using System.Text;

namespace PatronEstrategia.FormatosImagenes
{
    public abstract class BaseGuardarImagen
    {
        public string CrearImagen(string nombre , string extension) 
        {
            return $"Se ha guardado la imagen {nombre}.{extension}";
        }
    }
}
