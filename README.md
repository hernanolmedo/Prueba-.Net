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
response: Movimientos Cuenta (int)<br>
<br>
GET https://localhost:5001/info/SaldoFecha?numeroCuenta={numeroCuenta}<br>
response: Saldo Fecha Cuenta(Datetime)<br>
