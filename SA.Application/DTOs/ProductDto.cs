using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Application.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        // Aquí podrías agregar campos calculados que no existen en la BD, ej:
        // public string PriceWithTaxFormatted => $"{Price * 1.19m:C}";
    }
}
