using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class RecaudosConfiguracionesxEntidadesBancaria
{
    public int RecaudoConfiguracionxBancoId { get; set; }

    public int? RecaudoConfiguracionId { get; set; }

    public int? BancoId { get; set; }

    public virtual Banco? Banco { get; set; }

    public virtual RecaudosConfiguracione? RecaudoConfiguracion { get; set; }
}
