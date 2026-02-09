using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class PlanesEstudio
{
    public int PlanEstudioId { get; set; }

    public int ProgramaId { get; set; }

    public DateTime? FechaVigencia { get; set; }

    public int? MinimoCreditosObligatorios { get; set; }

    public int? MinimoCreditosElectivos { get; set; }

    public string Estado { get; set; } = null!;

    public string? UrlPlanEstudios { get; set; }

    public int Nivel { get; set; }

    public string? Codigo { get; set; }

    public virtual ICollection<AsignaturasxPlanesEstudio> AsignaturasxPlanesEstudios { get; set; } = new List<AsignaturasxPlanesEstudio>();

    public virtual ICollection<CreditosxNivel> CreditosxNivels { get; set; } = new List<CreditosxNivel>();

    public virtual ICollection<Homologacione> HomologacionePlanEstudioHomologacions { get; set; } = new List<Homologacione>();

    public virtual ICollection<Homologacione> HomologacionePlanEstudioNavigations { get; set; } = new List<Homologacione>();

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();

    public virtual ICollection<PlanesEstudiosxInscripcion> PlanesEstudiosxInscripcions { get; set; } = new List<PlanesEstudiosxInscripcion>();

    public virtual Programa Programa { get; set; } = null!;

    public virtual ICollection<Suficiencia> Suficiencia { get; set; } = new List<Suficiencia>();
}
