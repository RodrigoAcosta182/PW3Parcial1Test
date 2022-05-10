using Microsoft.AspNetCore.Mvc;
using RegistroDeVentas.Entities;
using RegistroDeVentas.Services.Interfaces;

namespace RegistroDeVentas.Controllers
{
    public class PresentacionWeb3Controller : Controller
    {
        private readonly IVentasServices _ventasServices; 

        public PresentacionWeb3Controller(IVentasServices ventasServices)
        {
            _ventasServices = ventasServices;
        }

        public IActionResult Bienvenidxs()
        {
            return View();
        } 
        public IActionResult VerResultado()
        {
            return View(_ventasServices.ObtenerVentas());
        }

        [HttpPost]
        public IActionResult RegistrarVenta(VentasViewModel ventaNueva)
        {
            _ventasServices.Registrar(ventaNueva);
            return View();
        }

        public IActionResult RegistrarVenta()
        {
            return View();
        }


    }
}
