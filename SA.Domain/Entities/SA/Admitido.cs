using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Admitido
{
    public int AdmitidosPeriodoId { get; set; }

    public int InscripcionId { get; set; }

    public bool? AdmisionEspecial { get; set; }

    public string? Observaciones { get; set; }

    public string ResponsableAdmision { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public int? PeriodoId { get; set; }

    public bool? ResultadoAdmision { get; set; }

    public int? Nivel { get; set; }

    public virtual Inscripcione Inscripcion { get; set; } = null!;

    public virtual Periodo? Periodo { get; set; }
}
