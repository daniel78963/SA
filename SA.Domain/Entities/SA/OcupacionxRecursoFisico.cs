using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

/// <summary>
/// Almacena la disponibilidad y ocupación del los recursos físicos
/// </summary>
public partial class OcupacionxRecursoFisico
{
    public int OcupacionRecursoFisicoId { get; set; }

    public int RecursoFisicoId { get; set; }

    public int TipoOcupacionId { get; set; }

    public int DiaId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public string? Recurrencia { get; set; }

    public int? RecurrenciaId { get; set; }

    public DateTime? FechaBaja { get; set; }

    public int? PeriodoId { get; set; }

    public int? CicloId { get; set; }

    public int? PersonaId { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual ActividadesCalendario? Ciclo { get; set; }

    public virtual Dia Dia { get; set; } = null!;

    public virtual ICollection<Entrevista> Entrevista { get; set; } = new List<Entrevista>();

    public virtual Persona? Persona { get; set; }

    public virtual RecursosFisico RecursoFisico { get; set; } = null!;

    public virtual ICollection<Suficiencia> Suficiencia { get; set; } = new List<Suficiencia>();

    public virtual TipoOcupacion TipoOcupacion { get; set; } = null!;
}
