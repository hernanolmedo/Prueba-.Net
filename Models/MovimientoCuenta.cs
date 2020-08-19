using System;
using System.ComponentModel.DataAnnotations;

namespace Prueba_.Net.Models{
    public class MovimientoCuenta{

        [Required]
        public int NumeroCuentaOrigen { get; set; }
        [Required]
        public int NumeroCuentaDestino { get; set; }
        [Required]
        public int Monto { get; set; }
        [Required]
        public DateTime Fecha { get; set; }

    }
}