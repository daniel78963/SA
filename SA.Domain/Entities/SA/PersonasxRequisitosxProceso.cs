using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

/// <summary>
/// Requisitos asociados al proceso en el que se encuentra la persona
/// </summary>
public partial class PersonasxRequisitosxProceso
{
    /// <summary>
    /// Consecutivo generado por el sistema
    /// </summary>
    public int PersonasxRequisitosxProcesoId { get; set; }

    /// <summary>
    /// Consecutivo que identifica la persona
    /// </summary>
    public int InscripcionId { get; set; }

    /// <summary>
    /// Consecutivo que identifica los requisitos del proceso en el que está asociada la persona
    /// </summary>
    public int RequisitosxProcesoId { get; set; }

    /// <summary>
    /// Estado de cumplimiento del requisito:02- Completado, 03-Aplazado, 01-Pendiente
    /// </summary>
    public int EstadoId { get; set; }

    /// <summary>
    /// Fecha en la que se completa el requisito
    /// </summary>
    public DateTime? FechaCumplimiento { get; set; }

    /// <summary>
    /// Comentarios ingresados cuando se otorgan conseciones especiales para completar el requisito
    /// </summary>
    public string? Observaciones { get; set; }

    /// <summary>
    /// Fecha de compromiso en la que se completará el requisito
    /// </summary>
    public DateTime? FechaCompromiso { get; set; }

    /// <summary>
    /// Fecha en la que se vence el requisito
    /// </summary>
    public DateTime? FechaVigenciaRequisito { get; set; }

    public int? PeriodoId { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public string? Anexo { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public virtual Estado Estado { get; set; } = null!;

    public virtual Inscripcione Inscripcion { get; set; } = null!;

    public virtual Periodo? Periodo { get; set; }

    public virtual RequisitosxProceso RequisitosxProceso { get; set; } = null!;
}
