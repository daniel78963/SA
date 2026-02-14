using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class InscripcionesResumenAcademico
{
    public int InscripcionResumenAcademico { get; set; }

    public int InscripcionId { get; set; }

    public int CantidadTotal { get; set; }

    public int CantidadGanadas { get; set; }

    public int CantidadPendientes { get; set; }

    public int CantidadCurso { get; set; }

    public int? PeriodoIdPrimeraMatricula { get; set; }

    public int? PeriodoIdUltimaMatricula { get; set; }

    public int? CantidadPeriodos { get; set; }

    public string? PeriodosAcumulados { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Usuario { get; set; }

    public virtual Inscripcione Inscripcion { get; set; } = null!;

    public virtual Periodo? PeriodoIdPrimeraMatriculaNavigation { get; set; }

    public virtual Periodo? PeriodoIdUltimaMatriculaNavigation { get; set; }
}
