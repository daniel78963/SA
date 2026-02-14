using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ViewPersonasxTipoPersona
{
    public int PersonaId { get; set; }

    public string Identificacion { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public int PersonasxRequisitosxProcesoId { get; set; }

    public DateTime? FechaCompromiso { get; set; }

    public DateTime? FechaCumplimiento { get; set; }

    public int RequisitosxProcesoId { get; set; }

    public int ProcesoId { get; set; }

    public string DescripProceso { get; set; } = null!;

    public int RequisitoId { get; set; }

    public string DescripRequisito { get; set; } = null!;

    public string DescripEstado { get; set; } = null!;

    public int EstadoId { get; set; }

    public int TipoEstadoId { get; set; }

    public string DescripTipEstado { get; set; } = null!;

    public int PeriodoId { get; set; }

    public string AnoCohorte { get; set; } = null!;

    public string SemestreCohorte { get; set; } = null!;

    public int InscripcionId { get; set; }

    public int EntrevistaInscripcionId { get; set; }
}
