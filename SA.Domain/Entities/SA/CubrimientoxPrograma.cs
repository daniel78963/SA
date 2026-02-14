using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CubrimientoxPrograma
{
    public int CubrimientoId { get; set; }

    public int UnidadOrganizacionalId { get; set; }

    public int ProgramaId { get; set; }

    public int TipoCubrimientoId { get; set; }

    /// <summary>
    /// 01-Presencial o a 02-distancia
    /// </summary>
    public string? Metodologia { get; set; }

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();

    public virtual Programa Programa { get; set; } = null!;

    public virtual TipoCubrimiento TipoCubrimiento { get; set; } = null!;
}
