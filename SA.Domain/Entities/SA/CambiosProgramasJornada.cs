using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CambiosProgramasJornada
{
    public int CambioEntidadId { get; set; }

    public int InscripcionId { get; set; }

    public int? ProgramaActualId { get; set; }

    public int? ProgramaCambioId { get; set; }

    public int EstadoId { get; set; }

    public DateTime? FechaAprobacion { get; set; }

    public int? JornadaActualId { get; set; }

    public int? JornadaCambioId { get; set; }

    public int PeriodoId { get; set; }

    public virtual Estado Estado { get; set; } = null!;

    public virtual Inscripcione Inscripcion { get; set; } = null!;

    public virtual TiposJornada? JornadaActual { get; set; }

    public virtual TiposJornada? JornadaCambio { get; set; }

    public virtual Periodo Periodo { get; set; } = null!;

    public virtual Programa? ProgramaActual { get; set; }

    public virtual Programa? ProgramaCambio { get; set; }
}
