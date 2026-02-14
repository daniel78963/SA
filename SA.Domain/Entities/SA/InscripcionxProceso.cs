using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

/// <summary>
/// Almacena los diferentes estados en el que se encuentra una inscripción
/// </summary>
public partial class InscripcionxProceso
{
    /// <summary>
    /// Cosecutivo generado por el sistema
    /// </summary>
    public int InscrpcionxProcesoId { get; set; }

    /// <summary>
    /// Consecutivo asociado a la insciprción
    /// </summary>
    public int ProcesoId { get; set; }

    /// <summary>
    /// Consecutivo de la inscripción
    /// </summary>
    public int InscripcionId { get; set; }

    public virtual Inscripcione Inscripcion { get; set; } = null!;

    public virtual Proceso Proceso { get; set; } = null!;
}
