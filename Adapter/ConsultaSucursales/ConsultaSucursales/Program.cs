using ConsultaSucursales.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsultaSucursales
{
    class Program
    {
        static void Main(string[] args)
        {
            IObtenerSucursalesJsonService obtenerSucursalesJsonService = new ObtenerSucursalesJsonService();
            IObtenerSucursalesService obtenerSucursalesService = new ConvertidorSucursales(obtenerSucursalesJsonService);
           // IObtenerSucursalesService obtenerSucursalesService1 =  new ObtenerSucursalesService(); Este es el servicio original, si se desea usar se debe pasar como parámetro al visualizador

            VisualizarSucursalesService visualizarSucursalesService = new VisualizarSucursalesService(obtenerSucursalesService);

            List<Sucursal> sucursales = visualizarSucursalesService.VisualizarSucursales();

            foreach (Sucursal sucursal in sucursales)
            {
                Console.WriteLine(sucursal.Id + "|" + sucursal.Nombre + "|" + sucursal.TotalVentas);
            }

        }
    }
}
