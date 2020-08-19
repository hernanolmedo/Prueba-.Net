# Prueba-.Net

**Webapi cuentas bancarias .NET Core 3.1**



POST  https://localhost:5001/login

body: {

    "Password": ,

    "Username": 

        } 

response: JWT

      

<br><br>GET https://localhost:5001/info/Saldo?numeroCuenta={numeroCuenta}

response: Saldo Cuenta(int)



<br><br>GET https://localhost:5001/info/SaldoTotal?numeroCuenta={numeroCuenta}

response: Saldo Total Cuenta(int)



<br><br>GET https://localhost:5001/info/MovimientosCuenta?numeroCuenta={numeroCuenta}

response: Movimientos Cuenta ({"numeroCuentaOrigen": int,"numeroCuentaDestino": int,"monto": int,"fecha": datetime}[])

Ejemplo:

[

    {

        "numeroCuentaOrigen": 345,

        "numeroCuentaDestino": 87,

        "monto": 3246234,

        "fecha": "2015-04-21T00:00:00"

    },

    {

        "numeroCuentaOrigen": 234,

        "numeroCuentaDestino": 846,

        "monto": 23462346,

        "fecha": "2014-02-01T00:00:00"

    },

    {

        "numeroCuentaOrigen": 63,

        "numeroCuentaDestino": 964,

        "monto": 5427456,

        "fecha": "2017-08-02T00:00:00"

    }

]



<br><br>GET https://localhost:5001/info/SaldoFecha?numeroCuenta={numeroCuenta}

response: Saldo Fecha Cuenta(Datetime)

