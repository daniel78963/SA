using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Dia
{
    public int DiaId { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<HorariosxDisponibilidadDocente> HorariosxDisponibilidadDocentes { get; set; } = new List<HorariosxDisponibilidadDocente>();

    public virtual ICollection<HorariosxGrupo> HorariosxGrupos { get; set; } = new List<HorariosxGrupo>();

    public virtual ICollection<OcupacionxDocente> OcupacionxDocentes { get; set; } = new List<OcupacionxDocente>();

    public virtual ICollection<OcupacionxRecursoFisico> OcupacionxRecursoFisicos { get; set; } = new List<OcupacionxRecursoFisico>();
}
