using System;
using System.Collections.Generic;

namespace SA.Domain.Entities.SA;

public partial class TiposCertificado
{
    public int TipoCertificadoId { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<CertificadosExpedido> CertificadosExpedidos { get; set; } = new List<CertificadosExpedido>();
}
