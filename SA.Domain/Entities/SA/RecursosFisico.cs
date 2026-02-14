using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class RecursosFisico
{
    public int RecursoFisicoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Ubicacion { get; set; } = null!;

    public int Capacidad { get; set; }

    public int TipoRecursoFisicoId { get; set; }

    public virtual ICollection<Entrevista> Entrevista { get; set; } = new List<Entrevista>();

    public virtual ICollection<HorariosxGrupo> HorariosxGrupos { get; set; } = new List<HorariosxGrupo>();

    public virtual ICollection<OcupacionxRecursoFisico> OcupacionxRecursoFisicos { get; set; } = new List<OcupacionxRecursoFisico>();

    public virtual ICollection<Suficiencia> Suficiencia { get; set; } = new List<Suficiencia>();

    public virtual TipoRecursoFisico TipoRecursoFisico { get; set; } = null!;
}
