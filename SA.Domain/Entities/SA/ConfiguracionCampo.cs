using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ConfiguracionCampo
{
    public int ConfiguracionCampoId { get; set; }

    public string? Nombre { get; set; }

    public int? FormId { get; set; }

    public int? TipoPersonaId { get; set; }

    public virtual ICollection<CamposxConfiguracion> CamposxConfiguracions { get; set; } = new List<CamposxConfiguracion>();
}
