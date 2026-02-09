using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class InstitucionesAcademica
{
    public int InstitucionAcademicaId { get; set; }

    public string? Nit { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    /// <summary>
    /// Activa/Inactiva
    /// </summary>
    public bool? Estado { get; set; }

    public bool Principal { get; set; }

    public int? OrigenId { get; set; }

    public int? OrdenId { get; set; }

    public int? CaracterAcademicoId { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Departamento { get; set; }

    public string? Municipio { get; set; }

    public int? MunicipioId { get; set; }

    public string? MunicipioCodigo { get; set; }

    public bool EducacionSuperior { get; set; }

    public virtual ICollection<Homologacione> Homologaciones { get; set; } = new List<Homologacione>();

    public virtual Orden? Orden { get; set; }

    public virtual Origen? Origen { get; set; }
}
