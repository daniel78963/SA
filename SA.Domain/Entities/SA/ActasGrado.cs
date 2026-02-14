using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ActasGrado
{
    public int ActaGradoId { get; set; }

    public string? Libro { get; set; }

    public string? Acta { get; set; }

    public int AreaConocimientoId { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Lugar { get; set; }

    public int? PeriodoId { get; set; }

    public int? RectorId { get; set; }

    public int? SecretariaGeneralId { get; set; }

    public int? DecanoId { get; set; }

    public int? ActaPadreId { get; set; }

    public string? TipoActa { get; set; }

    public virtual AreasNbc AreaConocimiento { get; set; } = null!;

    public virtual Persona? Decano { get; set; }

    public virtual ICollection<Graduando> Graduandos { get; set; } = new List<Graduando>();

    public virtual ICollection<InscripcionesxActasGrado> InscripcionesxActasGrados { get; set; } = new List<InscripcionesxActasGrado>();

    public virtual Persona? Rector { get; set; }

    public virtual Persona? SecretariaGeneral { get; set; }
}
