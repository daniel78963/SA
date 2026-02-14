using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class PersonasCaracterizacionAdicional
{
    public int PersonaCaracterizacionAdicionalId { get; set; }

    public int PersonaCaracterizacionId { get; set; }

    public int? SemestreCurso { get; set; }

    public int? PersonasCargoDiferentes { get; set; }

    public string? ExposicionEvento { get; set; }

    public string? OtroCualExposicionEvento { get; set; }

    public string? Afrodescendiente { get; set; }

    public string? Indigena { get; set; }

    public string? GrupoEtnicoResguardo { get; set; }

    public string? UbicacionGrupoEtnicoResguardo { get; set; }

    public string? PermanenciaGrupo { get; set; }

    public string? GrupoMinoritario { get; set; }

    public string? OtroCualGrupoMinoritario { get; set; }

    public bool? NecesidadInterrupcionAcademica { get; set; }

    public string? InterrupcionAcademica { get; set; }

    public string? OtroCualInterrupcionAcademica { get; set; }

    public string? PagoEstudios { get; set; }

    public string? OtroCualPagoEstudios { get; set; }

    public string? ActividadEconomica { get; set; }

    public string? ViviendaTipo { get; set; }

    public string? OtraCualViviendaTipo { get; set; }

    public string? GastosAdicionalesCubrimiento { get; set; }

    public string? OtroCualGastosAdicionalesCubrimiento { get; set; }

    public string? ApoyoSocioEconomicoUniversitario { get; set; }

    public string? OtroCualApoyoSocioEconomicoUniversitario { get; set; }

    public string? MotivoCarrera { get; set; }

    public string? OtroCualMotivoCarrera { get; set; }

    public string? GradoSatisfaccion { get; set; }

    public string? PorqueUniversidad { get; set; }

    public string? OtroCualPorqueUniversidad { get; set; }

    public string? NivelAdaptacion { get; set; }

    public string? OtroCualNivelAdaptacion { get; set; }

    public string? MedioTransporte { get; set; }

    public string? OtroCualMedioTransporte { get; set; }

    public string? GastosDinero { get; set; }

    public string? TiempoTraslado { get; set; }

    public string? OtrosEstudios { get; set; }

    public string? OtroCualOtrosEstudios { get; set; }

    public string? ContinuariaEstudiosPosgrado { get; set; }

    public string? PorqueContinuariaEstudiosPosgrado { get; set; }

    public string? AreaFormacionContinuariaEstudios { get; set; }

    public string? NivelFormacionAcademica { get; set; }

    public int? PeriodoIdIngreso { get; set; }

    public string? IngresosHogar { get; set; }

    public string? Discapacidad { get; set; }

    public virtual PersonasCaracterizacion PersonaCaracterizacion { get; set; } = null!;
}
