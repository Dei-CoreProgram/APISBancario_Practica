﻿namespace CuentaService.Models
{
    public class Cuenta
    {
        public int CuentaId { get; set; }
        public int ClienteId { get; set; }
        public string NumeroCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public decimal SaldoInicial { get; set; }
        public string Estado { get; set; }
    }
}
