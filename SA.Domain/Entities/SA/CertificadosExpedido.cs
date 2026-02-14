using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class CertificadosExpedido
{
    public int CertificadoExpedidoId { get; set; }

    public int TipoCertificadoId { get; set; }

    public string? NumeroRadicado { get; set; }

    public DateTime FechaExpedicion { get; set; }

    public byte[] CertificadoArchivoPlantilla { get; set; } = null!;

    public int InscripcionId { get; set; }

    public virtual Inscripcione Inscripcion { get; set; } = null!;

    public virtual TiposCertificado TipoCertificado { get; set; } = null!;
}
