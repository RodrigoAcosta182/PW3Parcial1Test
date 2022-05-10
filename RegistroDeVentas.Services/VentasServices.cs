using RegistroDeVentas.Entities;
using RegistroDeVentas.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeVentas.Services
{
    public class VentasServices : IVentasServices
    {
        Ventas _venta = new Ventas();
     
        public void Registrar(VentasViewModel ventaNueva)
        {
            _venta.addVentas(ventaNueva);
        }

        public List<VentasViewModel> ObtenerVentas()
        {
            return _venta.getVentas();
        }
    }
}
