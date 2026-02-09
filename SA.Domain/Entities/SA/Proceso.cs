using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

/// <summary>
/// Almacena información de los procesos universitarios]
/// </summary>
public partial class Proceso
{
    /// <summary>
    /// Código de identificación del proceso
    /// </summary>
    public int ProcesoId { get; set; }

    /// <summary>
    /// Nombre con el que se describe el proceso
    /// </summary>
    public string Descripcion { get; set; } = null!;

    public virtual ICollection<InscripcionxProceso> InscripcionxProcesos { get; set; } = new List<InscripcionxProceso>();

    public virtual ICollection<RequisitosxProceso> RequisitosxProcesos { get; set; } = new List<RequisitosxProceso>();
}
