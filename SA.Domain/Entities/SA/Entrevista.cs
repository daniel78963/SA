using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

/// <summary>
/// Almacena la información de las entrevistas, tanto disponibles como asignadas
/// </summary>
public partial class Entrevista
{
    public int EntrevistaId { get; set; }

    public int ProgramaId { get; set; }

    public int RecursoFisicoId { get; set; }

    /// <summary>
    /// Contiene el estado de la entrevista: disponible, asignada, reprogramada, no asistida, cancelada
    /// </summary>
    public int EstadoId { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public int? PeriodoId { get; set; }

    public int? OcupacionRecursoFisicoId { get; set; }

    public virtual ICollection<EntrevistasxInscripcion> EntrevistasxInscripcions { get; set; } = new List<EntrevistasxInscripcion>();

    public virtual OcupacionxRecursoFisico? OcupacionRecursoFisico { get; set; }

    public virtual Periodo? Periodo { get; set; }

    public virtual Programa Programa { get; set; } = null!;

    public virtual RecursosFisico RecursoFisico { get; set; } = null!;

    public virtual ICollection<ResponsablexEntrevistum> ResponsablexEntrevista { get; set; } = new List<ResponsablexEntrevistum>();
}
