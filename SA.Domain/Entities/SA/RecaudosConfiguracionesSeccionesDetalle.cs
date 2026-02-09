using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class RecaudosConfiguracionesSeccionesDetalle
{
    public int RecaudoConfiguracionConfiguracionId { get; set; }

    public int? RecaudoConfiguracionSeccionId { get; set; }

    public string? NombreCampo { get; set; }

    public int LogitudTexto { get; set; }

    public string? Formato { get; set; }

    public string? Descripcion { get; set; }

    public int? Orden { get; set; }

    public bool Activo { get; set; }

    public string? EquivalenciaRecaudosCampos { get; set; }

    public virtual RecaudosConfiguracionesSeccione? RecaudoConfiguracionSeccion { get; set; }
}
