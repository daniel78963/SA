using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class NovedadesNota
{
    public int NovedadNotaId { get; set; }

    /// <summary>
    /// TipoNovedad: Grupal: Habilitar todas las notas del grupo. TipoEvaluacion: Habilitar por Tipo Evaluación (Seguimiento I ó Seguimiento II o Final o Parcial) Estudiante: Habilitar todas las notas de un estudiante. Puntual: Habilitar el ingreso de una sola nota.
    /// </summary>
    public string TipoNovedad { get; set; } = null!;

    public string ObservacionesSolicitud { get; set; } = null!;

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public string UsuarioSolicitud { get; set; } = null!;

    public DateTime FechaSolicitud { get; set; }

    public string? UsuarioAprobacion { get; set; }

    public DateTime? FechaAprobacion { get; set; }

    public string? ObservacionesAprobacion { get; set; }

    public int PeriodoId { get; set; }

    public int EstadoSolicitudId { get; set; }

    public virtual Estado EstadoSolicitud { get; set; } = null!;

    public virtual ICollection<NovedadesNotasDetalle> NovedadesNotasDetalles { get; set; } = new List<NovedadesNotasDetalle>();

    public virtual Periodo Periodo { get; set; } = null!;
}
