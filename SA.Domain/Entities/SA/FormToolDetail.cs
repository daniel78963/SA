using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class FormToolDetail
{
    public int FormToolDetailsId { get; set; }

    public int FormToolId { get; set; }

    public string NombreCampo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Requerido { get; set; }

    public string TipoCampo { get; set; } = null!;

    public int? Longitud { get; set; }

    public string? TipoCampoCalculado { get; set; }

    public string? MostrarComo { get; set; }

    public int? MinValue { get; set; }

    public int? MaxValue { get; set; }

    public int? NumeroLineas { get; set; }

    public int? ListaToolId { get; set; }

    public string? ExpresionCalculo { get; set; }

    public int? ListaFormToolId { get; set; }

    public int? Index { get; set; }

    public bool? NombreEmpresa { get; set; }

    public bool? Universidad { get; set; }

    public bool? Correo { get; set; }

    public virtual ICollection<CamposxConfiguracion> CamposxConfiguracions { get; set; } = new List<CamposxConfiguracion>();

    public virtual FormTool FormTool { get; set; } = null!;

    public virtual ICollection<FormToolDetailsOption> FormToolDetailsOptions { get; set; } = new List<FormToolDetailsOption>();

    public virtual ICollection<FormToolValuesDetail> FormToolValuesDetails { get; set; } = new List<FormToolValuesDetail>();

    public virtual FormTool? ListaFormTool { get; set; }
}
