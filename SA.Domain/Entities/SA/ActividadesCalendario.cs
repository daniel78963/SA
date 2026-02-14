using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ActividadesCalendario
{
    public int ActividadesCalendarioId { get; set; }

    public int CalendarioId { get; set; }

    public int ActividadId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaCierre { get; set; }

    public int TipoUnidadOrganizacionalId { get; set; }

    public int EstadoActividadId { get; set; }

    public virtual Actividade Actividad { get; set; } = null!;

    public virtual Calendario Calendario { get; set; } = null!;

    public virtual ICollection<HorariosxGrupo> HorariosxGrupos { get; set; } = new List<HorariosxGrupo>();

    public virtual ICollection<OcupacionxDocente> OcupacionxDocentes { get; set; } = new List<OcupacionxDocente>();

    public virtual ICollection<OcupacionxRecursoFisico> OcupacionxRecursoFisicos { get; set; } = new List<OcupacionxRecursoFisico>();

    public virtual TipoUnidadOrganizacional TipoUnidadOrganizacional { get; set; } = null!;
}
