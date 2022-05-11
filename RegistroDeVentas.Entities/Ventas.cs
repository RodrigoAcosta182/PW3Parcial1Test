using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeVentas.Entities
{
    public class Ventas
    {
        public List<VentasViewModel> _ventas = new List<VentasViewModel>()
        {
            new VentasViewModel(){Cliente = "El Polaco", CantidadVendida = 100, PrecioUnitario = 10, Total = 1210},
            new VentasViewModel(){Cliente = "El Traidor", CantidadVendida = 200, PrecioUnitario = 10, Total = 2420},
            new VentasViewModel(){Cliente = "Pablito Lescano", CantidadVendida = 300, PrecioUnitario = 10, Total = 3630},
        };

        public List<VentasViewModel> getVentas()
        {
            return _ventas;
        }

        public void addVentas(VentasViewModel nuevaVenta)
        {
            _ventas.Add(nuevaVenta);
        }
    }
}
