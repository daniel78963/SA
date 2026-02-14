using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CamposxConfiguracion
{
    public int CampoxConfiguracionId { get; set; }

    public int CampoId { get; set; }

    public int? ConfiguracionCamposId { get; set; }

    public virtual FormToolDetail Campo { get; set; } = null!;

    public virtual ConfiguracionCampo? ConfiguracionCampos { get; set; }
}
