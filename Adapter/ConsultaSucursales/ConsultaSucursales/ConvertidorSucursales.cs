using ConsultaSucursales.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultaSucursales
{
    public class ConvertidorSucursales : IObtenerSucursalesService
    {
        public IObtenerSucursalesJsonService _obtenerSucursalesJsonService;

        public ConvertidorSucursales(IObtenerSucursalesJsonService obtenerSucursalesJsonService)
        {
            _obtenerSucursalesJsonService = obtenerSucursalesJsonService;
        }
        public List<Sucursal> ObtenerSucursales()
        {
          string sucursajesJson=  _obtenerSucursalesJsonService.ObtenerSucursales();

            return JsonConvert.DeserializeObject<List<Sucursal>>(sucursajesJson);
        }
    }
}
