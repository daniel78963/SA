using SA.Application.DTOs;
using SA.Domain.Entities;

namespace SA.Application.Interfaces
{
    ///Aquí implementamos la lógica de negocio. El servicio orquesta los datos usando la interfaz del repositorio, sin saber si viene de SQL Server o de un archivo de texto.
    public interface IProductService
    {
        //Task<IEnumerable<Product>> GetProductsAsync();
        //Task<Product?> GetProductByIdAsync(int id);
        //Task<Product> CreateProductAsync(Product product);
        //Task UpdateProductAsync(Product product);
        //Task DeleteProductAsync(int id);
        Task<IEnumerable<ProductDto>> GetProductsAsync();
        Task<ProductDto?> GetProductByIdAsync(int id);
        Task<ProductDto> CreateProductAsync(CreateProductDto productDto);
        // Task UpdateProductAsync(UpdateProductDto productDto); // Se recomienda un DTO distinto para update
        Task DeleteProductAsync(int id);
    }
}
