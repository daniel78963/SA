using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class InformacionAdicional
{
    public int InformacionAdicionalId { get; set; }

    public int PersonaId { get; set; }

    public bool? Financiacion { get; set; }

    public string? EntidadCreditoId { get; set; }

    public int? NumPersonasGrupoFliar { get; set; }

    public int? NumAportantes { get; set; }

    public int? IngresosFamiliares { get; set; }

    public bool? ViviendaPropia { get; set; }

    public bool? DeudaVivienda { get; set; }

    public int? RangosHermanoId { get; set; }

    public int? PosicionHermanos { get; set; }

    public int HnosEstudioSuperior { get; set; }

    public string? PaisFronteraId { get; set; }

    public bool? Vulnerable { get; set; }

    public bool? Victima { get; set; }

    public string? MunicipioId { get; set; }

    public bool? GrupoEtnico { get; set; }

    public int? EtniaId { get; set; }

    public bool? SectorPrivado { get; set; }

    public bool? NecesidadesEspeciales { get; set; }

    public int? CapacidadId { get; set; }

    public string? RazonPresentacion { get; set; }

    public bool? RequiereAyudaFinanciero { get; set; }

    public int? PorcentajeFinanciacion { get; set; }

    public int? PorcentajeEntregado { get; set; }

    public bool? RequiereAyudaAcademica { get; set; }

    public bool? RecibioApoyoAcademico { get; set; }

    public int? SatisfaccionApoyoAcademico { get; set; }

    public bool? RequiereOtrasAyudas { get; set; }

    public bool? RecibioOtrasAyudas { get; set; }

    public int? SatisfaccionOtrasAyudas { get; set; }

    public decimal? ValorPagadoIes { get; set; }

    public bool? Discapacidad { get; set; }

    public int? DiscapacidadId { get; set; }

    public string? DepartamentoId { get; set; }

    public virtual Capacidade? Capacidad { get; set; }

    public virtual Discapacidade? DiscapacidadNavigation { get; set; }

    public virtual Etnia? Etnia { get; set; }

    public virtual Persona Persona { get; set; } = null!;

    public virtual RangosHermano? RangosHermano { get; set; }
}
