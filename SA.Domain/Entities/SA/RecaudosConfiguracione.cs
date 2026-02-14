using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class RecaudosConfiguracione
{
    public int RecaudoConfiguracionId { get; set; }

    public int? BancoId { get; set; }

    public string? NombreRecaudoConfiguracionxBanco { get; set; }

    public string? Version { get; set; }

    public string? Descripcion { get; set; }

    public bool Activo { get; set; }

    public virtual Banco? Banco { get; set; }

    public virtual ICollection<RecaudosConfiguracionesSeccione> RecaudosConfiguracionesSecciones { get; set; } = new List<RecaudosConfiguracionesSeccione>();

    public virtual ICollection<RecaudosConfiguracionesxEntidadesBancaria> RecaudosConfiguracionesxEntidadesBancaria { get; set; } = new List<RecaudosConfiguracionesxEntidadesBancaria>();
}
