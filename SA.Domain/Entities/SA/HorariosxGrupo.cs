using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class HorariosxGrupo
{
    public int HorarioGrupoId { get; set; }

    public DateTime HoraInicio { get; set; }

    public DateTime HoraFin { get; set; }

    public int DiaId { get; set; }

    public int GrupoId { get; set; }

    public int? RecursoFisicoId { get; set; }

    public int? OcupacionRecursoFisicoId { get; set; }

    public int? CicloId { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual ActividadesCalendario? Ciclo { get; set; }

    public virtual Dia Dia { get; set; } = null!;

    public virtual Grupo Grupo { get; set; } = null!;

    public virtual RecursosFisico? RecursoFisico { get; set; }
}
