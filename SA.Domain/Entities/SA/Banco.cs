using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Banco
{
    public int BancoId { get; set; }

    public string? NombreBanco { get; set; }

    public string? CodigoBanco { get; set; }

    public bool Mostrar { get; set; }

    public virtual ICollection<BancosxCuenta> BancosxCuenta { get; set; } = new List<BancosxCuenta>();

    public virtual ICollection<Recaudo> Recaudos { get; set; } = new List<Recaudo>();

    public virtual ICollection<RecaudosConfiguracione> RecaudosConfiguraciones { get; set; } = new List<RecaudosConfiguracione>();

    public virtual ICollection<RecaudosConfiguracionesxEntidadesBancaria> RecaudosConfiguracionesxEntidadesBancaria { get; set; } = new List<RecaudosConfiguracionesxEntidadesBancaria>();
}
