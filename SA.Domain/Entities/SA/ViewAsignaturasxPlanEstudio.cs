using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ViewAsignaturasxPlanEstudio
{
    public int AsignaturasxProgramaId { get; set; }

    public string NombreAsignatura { get; set; } = null!;

    public string DescripcionEstadoAsignatura { get; set; } = null!;

    public string EstadoPlanesEstudio { get; set; } = null!;

    public string EstadosAsigxPlanEstudios { get; set; } = null!;

    public int Nivel { get; set; }

    public int ProgramaId { get; set; }

    public DateTime? FechaVigencia { get; set; }
}
