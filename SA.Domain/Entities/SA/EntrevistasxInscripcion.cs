using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class EntrevistasxInscripcion
{
    public int EntrevistaInscripcionId { get; set; }

    public int EntrevistaId { get; set; }

    public int InscripcionId { get; set; }

    public string? DesvAcademica { get; set; }

    public bool? SegundoIdioma { get; set; }

    public string? DesSegundoIdioma { get; set; }

    public bool? Hinformaticas { get; set; }

    public string? DesHinformaticas { get; set; }

    public bool? ActitudPositiva { get; set; }

    public bool? CapComunicacion { get; set; }

    public bool? Seguridad { get; set; }

    public bool? CapInteraccion { get; set; }

    public bool? Claridad { get; set; }

    public string? Logros { get; set; }

    public bool? Limitaciones { get; set; }

    public bool? Metas { get; set; }

    public string? ConocelaU { get; set; }

    public string? RazonesU { get; set; }

    public string? RazonesPgma { get; set; }

    public bool? OtraOp { get; set; }

    public string? DesOtraOp { get; set; }

    public string? OtraInstitucion { get; set; }

    public bool? Apoyo { get; set; }

    public string? AreasApoyo { get; set; }

    public string? Concepto { get; set; }

    public bool? VtoBno { get; set; }

    public DateTime? FechaEntrevista { get; set; }

    public int? PersonaId { get; set; }

    public bool? NoPresentada { get; set; }

    public virtual Entrevista Entrevista { get; set; } = null!;

    public virtual Inscripcione Inscripcion { get; set; } = null!;
}
