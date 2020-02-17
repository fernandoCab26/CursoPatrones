using ConsultaSucursales.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ConsultaSucursales
{
    public class ObtenerSucursalesJsonService : IObtenerSucursalesJsonService
    {
        public string ObtenerSucursales()
        {
            List<Sucursal> sucursales = new List<Sucursal> {
                new Sucursal{ Id="1", Nombre="Sucursal1 JSon", TotalVentas=323 },
                new Sucursal{ Id="2", Nombre="Sucursal2 Json", TotalVentas=989 },
                new Sucursal{ Id="3", Nombre="Sucursal3 Json", TotalVentas=212 }
           };

            return JsonConvert.SerializeObject(sucursales);
        }
    }
}
