using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeVentas.Entities
{
    public class VentasViewModel
    {
        [Required(ErrorMessage = "El campo Cliente es requerido")]
        [MaxLength(50,ErrorMessage = "El campo Cliente no debe superar los 50 caracteres")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "El campo CantidadVendida es requerido")]
        [Range(1,250, ErrorMessage = "La CantidadVendida debe ser entre 1 y 250")]
        public int CantidadVendida { get; set; }

        [Required(ErrorMessage = "El campo CantidadVendida es requerido")]
        [Range(10, 999, ErrorMessage = "La CantidadVendida debe ser mayor a 10 y menor a 999")]
        public double PrecioUnitario { get; set; }

        public double Total { get; set; }
    }
}
