using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ViewDocenteProgramacion
{
    public int DocenteId { get; set; }

    public int PersonaId { get; set; }

    public int DocentesAsignaturaId { get; set; }

    public int AsignaturasxProgramaId { get; set; }

    public int GrupoId { get; set; }

    public string DescripcionGrupo { get; set; } = null!;

    public string NombreAsignaturaGrupo { get; set; } = null!;

    public int PeriodoId { get; set; }

    public int ProgramaId { get; set; }

    public string NombrePrograma { get; set; } = null!;
}
