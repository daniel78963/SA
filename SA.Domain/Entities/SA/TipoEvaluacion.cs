using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TipoEvaluacion
{
    public int TipoEvaluacionId { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal PorcentajeTipoEvaluacion { get; set; }

    public int PeriodoId { get; set; }

    public bool? Activo { get; set; }

    public bool? Modificable { get; set; }

    public int? Orden { get; set; }

    public decimal? PorcentajeMaximoItem { get; set; }

    public decimal? PorcentajeMinimoItem { get; set; }

    public int? NumeroMaximoRepeticiones { get; set; }

    public int? Iesid { get; set; }

    public int? ProgramaId { get; set; }

    public virtual Ie? Ies { get; set; }

    public virtual ICollection<NovedadesNotasDetalle> NovedadesNotasDetalles { get; set; } = new List<NovedadesNotasDetalle>();

    public virtual Periodo Periodo { get; set; } = null!;

    public virtual Programa? Programa { get; set; }

    public virtual ICollection<ProgramacionEvaluacion> ProgramacionEvaluacions { get; set; } = new List<ProgramacionEvaluacion>();
}
