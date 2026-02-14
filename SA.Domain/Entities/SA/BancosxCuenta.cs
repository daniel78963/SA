using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class BancosxCuenta
{
    public int BancoxCuentaId { get; set; }

    public int BancoId { get; set; }

    public string? CuentaNumero { get; set; }

    public string? DescripcionCuenta { get; set; }

    /// <summary>
    /// Clave primaria de las cuentas contables del sistema SAG Financiero para saber a que cuenta deben entrar los pagos
    /// </summary>
    public int? KaNiCuentaBanco { get; set; }

    public bool Activa { get; set; }

    public string? PasarelaPaymentMethod { get; set; }

    public int? Iesid { get; set; }

    public virtual Banco Banco { get; set; } = null!;
}
