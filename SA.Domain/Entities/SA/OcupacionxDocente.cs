using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

/// <summary>
/// Almacena la disponibilidad y ocupación de los docentes
/// </summary>
public partial class OcupacionxDocente
{
    public int OcupacionDocenteId { get; set; }

    public int TipoOcupacionDocenteId { get; set; }

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

    public int? ProgramaId { get; set; }

    public virtual ActividadesCalendario? Ciclo { get; set; }

    public virtual Dia Dia { get; set; } = null!;

    public virtual Periodo? Periodo { get; set; }

    public virtual Persona? Persona { get; set; }

    public virtual Programa? Programa { get; set; }

    public virtual TipoOcupacionDocente TipoOcupacionDocente { get; set; } = null!;
}
