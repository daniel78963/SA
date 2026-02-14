using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class AsignaturasxPrograma
{
    public int AsignaturasxProgramaId { get; set; }

    public int ProgramaId { get; set; }

    public string CodigoIes { get; set; } = null!;

    public string NombreAsignatura { get; set; } = null!;

    public bool EsExtension { get; set; }

    public int? EstadoAsignaturaId { get; set; }

    public int? AreaNbcid { get; set; }

    public int? AsignaturasxProgramaSubgrupoId { get; set; }

    public virtual AreasNbc? AreaNbc { get; set; }

    public virtual ICollection<AsignaturasxPlanesEstudio> AsignaturasxPlanesEstudios { get; set; } = new List<AsignaturasxPlanesEstudio>();

    public virtual AsignaturasxProgramaxSubgrupo? AsignaturasxProgramaSubgrupo { get; set; }

    public virtual ICollection<AsignaturasxProgramasxDocente> AsignaturasxProgramasxDocentes { get; set; } = new List<AsignaturasxProgramasxDocente>();

    public virtual ICollection<DocentesxAsignatura> DocentesxAsignaturas { get; set; } = new List<DocentesxAsignatura>();

    public virtual EstadoAsignatura? EstadoAsignatura { get; set; }

    public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();

    public virtual Programa Programa { get; set; } = null!;
}
