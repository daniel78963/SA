using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class Homologacione
{
    public int HomologacionId { get; set; }

    public string? Descripcion { get; set; }

    public int? PeriodoId { get; set; }

    public int? InscripcionId { get; set; }

    public DateTime? Fecha { get; set; }

    public bool? Externa { get; set; }

    public string? Universidad { get; set; }

    public string? Programa { get; set; }

    public string? PlanEstudio { get; set; }

    public int? Iesid { get; set; }

    public int? ProgramaId { get; set; }

    public int? PlanEstudioId { get; set; }

    public int? IeshomologacionId { get; set; }

    public int? ProgramaHomologacionId { get; set; }

    public int? PlanEstudioHomologacionId { get; set; }

    public string? Codigo { get; set; }

    public string? CodigoActa { get; set; }

    public DateTime? FechaActa { get; set; }

    public bool? NoHomologada { get; set; }

    public string? TipoObjeto { get; set; }

    public int? InstitucionAcademicaId { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public string? Usuario { get; set; }

    public virtual ICollection<HomologacionesDetalle> HomologacionesDetalles { get; set; } = new List<HomologacionesDetalle>();

    public virtual Ie? Ies { get; set; }

    public virtual Ie? Ieshomologacion { get; set; }

    public virtual Inscripcione? Inscripcion { get; set; }

    public virtual InstitucionesAcademica? InstitucionAcademica { get; set; }

    public virtual Periodo? Periodo { get; set; }

    public virtual PlanesEstudio? PlanEstudioHomologacion { get; set; }

    public virtual PlanesEstudio? PlanEstudioNavigation { get; set; }

    public virtual Programa? ProgramaHomologacion { get; set; }

    public virtual Programa? ProgramaNavigation { get; set; }
}
