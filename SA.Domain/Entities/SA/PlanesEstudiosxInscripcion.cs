using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class PlanesEstudiosxInscripcion
{
    public int PlanEstudioXestudianteId { get; set; }

    public int InscripcionId { get; set; }

    public int PlanEstudioId { get; set; }

    public DateTime? FechaPlanEstudioInscripcion { get; set; }

    public bool? Activa { get; set; }

    public virtual Inscripcione Inscripcion { get; set; } = null!;

    public virtual PlanesEstudio PlanEstudio { get; set; } = null!;
}
