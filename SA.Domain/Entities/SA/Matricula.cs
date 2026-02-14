using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Matricula
{
    public int MatriculaId { get; set; }

    public string? Codigo { get; set; }

    public DateTime? Fecha { get; set; }

    /// <summary>
    /// MATRICULA, INSCRIPCION, ADICION
    /// </summary>
    public string? Concepto { get; set; }

    public int? PeriodoId { get; set; }

    public int? InscripcionId { get; set; }

    public int? EstadoId { get; set; }

    public int? TipoIngresoId { get; set; }

    public int? TipoPagoId { get; set; }

    public string? UsuarioMatricula { get; set; }

    public DateTime? FechaAsentada { get; set; }

    public string? UsuarioAsentada { get; set; }

    public string? Rol { get; set; }

    public string? UsuarioCancelada { get; set; }

    public DateTime? FechaCancelada { get; set; }

    public int? AntiguedadId { get; set; }

    public int? JornadaId { get; set; }

    public int? ModalidadCategoriaId { get; set; }

    public decimal? NotaPromedio { get; set; }

    public string? UsuarioPromedio { get; set; }

    public DateTime? FechaPromedio { get; set; }

    public int? PlanEstudioId { get; set; }

    public virtual Antiguedade? Antiguedad { get; set; }

    public virtual Estado? Estado { get; set; }

    public virtual ICollection<HistoricoNota> HistoricoNota { get; set; } = new List<HistoricoNota>();

    public virtual Inscripcione? Inscripcion { get; set; }

    public virtual ICollection<InscritosxGruposxAsignatura> InscritosxGruposxAsignaturas { get; set; } = new List<InscritosxGruposxAsignatura>();

    public virtual TiposJornada? Jornada { get; set; }

    public virtual ICollection<Liquidacione> Liquidaciones { get; set; } = new List<Liquidacione>();

    public virtual ModalidadesCategoria? ModalidadCategoria { get; set; }

    public virtual Periodo? Periodo { get; set; }

    public virtual PlanesEstudio? PlanEstudio { get; set; }

    public virtual TiposIngreso? TipoIngreso { get; set; }

    public virtual TiposPago? TipoPago { get; set; }
}
