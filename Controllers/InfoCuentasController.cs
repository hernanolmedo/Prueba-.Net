using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Prueba_.Net.Models;

namespace Prueba_.Net.Controllers
{
    [ApiController]
    [Route("info")]
    public class InfoCuentasController : ControllerBase
    {
        [Route("Saldo")]
        [HttpGet("{numeroCuenta}")]
        public int Saldo(int numeroCuenta)
        {
            int response = 56856;
            return response;
        }

        [Route("SaldoTotal")]
        [HttpGet("{numeroCuenta}")]
        public int SaldoTotal(int numeroCuenta)
        {
            int response = 745612;
            return response;
        }

        [Route("MovimientosCuenta")]
        [HttpGet("{numeroCuenta}")]
        public IEnumerable<MovimientoCuenta> MovimientosCuenta(int numeroCuenta)
        {
            IEnumerable<MovimientoCuenta> response = new MovimientoCuenta[]
            {
                new MovimientoCuenta {NumeroCuentaOrigen=345,NumeroCuentaDestino=87,Monto=3246234,Fecha=new DateTime(2015, 4, 21)},
                new MovimientoCuenta {NumeroCuentaOrigen=234,NumeroCuentaDestino=846,Monto=23462346,Fecha=new DateTime(2014, 2, 1)},
                new MovimientoCuenta {NumeroCuentaOrigen=63,NumeroCuentaDestino=964,Monto=5427456,Fecha=new DateTime(2017, 8, 2)},
                new MovimientoCuenta {NumeroCuentaOrigen=2634,NumeroCuentaDestino=7,Monto=72456254,Fecha=new DateTime(2019, 6, 3)}
            };
            return response;
        }

        [Route("SaldoFecha")]
        [HttpGet("{numeroCuenta,fecha}")]
        public int SaldoFecha(int numeroCuenta, DateTime fecha)
        {
            int response = 324623;
            return response;
        }
    }
}
