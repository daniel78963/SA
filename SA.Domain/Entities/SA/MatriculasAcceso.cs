using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class MatriculasAcceso
{
    public int MatriculaAccesoId { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public int? InscripcionId { get; set; }

    public int? PeriodoId { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual Inscripcione? Inscripcion { get; set; }

    public virtual Periodo? Periodo { get; set; }
}
