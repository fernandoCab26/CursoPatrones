using ConsultaSucursales.Interfaces;
using System.Collections.Generic;

namespace ConsultaSucursales
{
    public class VisualizarSucursalesService : IVisualizarSucursalesService
    {
        private readonly IObtenerSucursalesService _obtenerSucursalesService;
        public VisualizarSucursalesService(IObtenerSucursalesService obtenerSucursalesService)
        {
            _obtenerSucursalesService = obtenerSucursalesService;
        }
        public List<Sucursal> VisualizarSucursales()
        {
            return _obtenerSucursalesService.ObtenerSucursales();
        }
    }
}
