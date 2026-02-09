using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AsignaturasxPlanesEstudioExcepcionesxInscripcione
{
    public int AsignaturaPlanEstudioxInscripcionId { get; set; }

    public int InscripcionId { get; set; }

    public int PlanEstudioAsignaturaId { get; set; }

    public string Justificacion { get; set; } = null!;

    public string? Usuario { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual Inscripcione Inscripcion { get; set; } = null!;

    public virtual AsignaturasxPlanesEstudio PlanEstudioAsignatura { get; set; } = null!;
}
