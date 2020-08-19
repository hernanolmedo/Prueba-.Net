# Prueba-.Net<br>
Webapi cuentas bancarias ASP.NET Core<br>
<br>
POST  https://localhost:5001/login<br>
body: {<br>
    "Password": ,<br>
    "Username": <br>
      } <br>
response: JWT<br>
      <br>
GET https://localhost:5001/info/Saldo?numeroCuenta={numeroCuenta}<br>
response: Saldo Cuenta(int)<br>
<br>
GET https://localhost:5001/info/SaldoTotal?numeroCuenta={numeroCuenta}<br>
response: Saldo Total Cuenta(int)<br>
<br>
GET https://localhost:5001/info/MovimientosCuenta?numeroCuenta={numeroCuenta}<br>
response: Movimientos Cuenta ({"numeroCuentaOrigen": int,"numeroCuentaDestino": int,"monto": int,"fecha": datetime}[])<br>
Ejemplo:<br>
[<br>
    {<br>
        "numeroCuentaOrigen": 345,<br>
        "numeroCuentaDestino": 87,<br>
        "monto": 3246234,<br>
        "fecha": "2015-04-21T00:00:00"<br>
    },<br>
    {<br>
        "numeroCuentaOrigen": 234,<br>
        "numeroCuentaDestino": 846,<br>
        "monto": 23462346,<br>
        "fecha": "2014-02-01T00:00:00"<br>
    },<br>
    {<br>
        "numeroCuentaOrigen": 63,<br>
        "numeroCuentaDestino": 964,<br>
        "monto": 5427456,<br>
        "fecha": "2017-08-02T00:00:00"<br>
    }<br>
]<br>
<br>
GET https://localhost:5001/info/SaldoFecha?numeroCuenta={numeroCuenta}<br>
response: Saldo Fecha Cuenta(Datetime)<br>
