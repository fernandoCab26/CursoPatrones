using ConsultaSucursales.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultaSucursales
{
    public class ObtenerSucursalesService : IObtenerSucursalesService
    {
        public List<Sucursal> ObtenerSucursales()
        {
            return new List<Sucursal> {
                new Sucursal{ Id="1", Nombre="Sucursal1", TotalVentas=323 },
                new Sucursal{ Id="2", Nombre="Sucursal2", TotalVentas=989 },
                new Sucursal{ Id="3", Nombre="Sucursal3", TotalVentas=212 }
           };
        }
    }
}
