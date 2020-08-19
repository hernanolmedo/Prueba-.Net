# Prueba-.Net
Webapi cuentas bancarias ASP.NET Core

POST  https://localhost:5001/login
body: {
    "Password": ,
    "Username": 
      } 
response: JWT
      
GET https://localhost:5001/info/Saldo?numeroCuenta={numeroCuenta}
response: Saldo Cuenta(int)

GET https://localhost:5001/info/SaldoTotal?numeroCuenta={numeroCuenta}
response: Saldo Total Cuenta(int)

GET https://localhost:5001/info/MovimientosCuenta?numeroCuenta={numeroCuenta}
response: Movimientos Cuenta (int)

GET https://localhost:5001/info/SaldoFecha?numeroCuenta={numeroCuenta}
response: Saldo Fecha Cuenta(Datetime)
