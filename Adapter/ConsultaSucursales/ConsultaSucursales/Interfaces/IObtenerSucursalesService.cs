using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultaSucursales.Interfaces
{
   public interface IObtenerSucursalesService
    {
        List<Sucursal> ObtenerSucursales();
    }
}
