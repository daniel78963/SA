using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class ViewEntrevistum
{
    public int UnidadOrganizacionalId { get; set; }

    public string NombreUnidad { get; set; } = null!;

    public int ProgramaId { get; set; }

    public string NombrePrograma { get; set; } = null!;

    public int EntrevistaId { get; set; }

    public string? FechaInicio { get; set; }

    public string? HoraInicio { get; set; }

    public string? HoraFin { get; set; }

    public int RecursoFisicoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public int ResponsableEntrevistaId { get; set; }

    public int PersonaId { get; set; }

    public string Usuario { get; set; } = null!;

    public int EstadoId { get; set; }

    public string EstDescrip { get; set; } = null!;

    public string? IdenAspirante { get; set; }
}
