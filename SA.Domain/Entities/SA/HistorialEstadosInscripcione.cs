using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

/// <summary>
/// Contiene el histórico de los diferentes estados del proceso conforme la evolución de la inscripción
/// </summary>
public partial class HistorialEstadosInscripcione
{
    /// <summary>
    /// Consecutivo generado por el sistema
    /// </summary>
    public int HistorialInscripcionId { get; set; }

    /// <summary>
    /// Consecutivo de la Inscripción
    /// </summary>
    public int InscripcionId { get; set; }

    /// <summary>
    /// Proceso en el que se encuentra la inscripción
    /// </summary>
    public int PcsoActual { get; set; }

    /// <summary>
    /// Proceso anterior al proceso actual de la proceso de inscripción
    /// </summary>
    public int? PcsoAnterior { get; set; }

    /// <summary>
    /// Proceso posterior al que evolucionó la inscripción
    /// </summary>
    public int? PcsoPosterior { get; set; }

    /// <summary>
    /// Fecha del proceso actual en el que se encuentra la inscripción
    /// </summary>
    public DateOnly FechaPcsoActual { get; set; }

    /// <summary>
    /// Fecha del proceso anterior al proceso actual de la proceso de inscripción
    /// </summary>
    public DateOnly? FechaPcsoAnterior { get; set; }

    /// <summary>
    /// Fecha del proceso posterior al que evolucionó la inscripción
    /// </summary>
    public DateOnly? FechaPcsoPosterior { get; set; }

    public int? PeriodoId { get; set; }

    public virtual Inscripcione Inscripcion { get; set; } = null!;
}
