using RegistroDeVentas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeVentas.Services.Interfaces
{
    public interface IVentasServices
    {
        public void Registrar(VentasViewModel ventaNueva);
        public List<VentasViewModel> ObtenerVentas();
    }
}
