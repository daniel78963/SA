using SA.Application.DTOs;
using SA.Application.Interfaces;
using SA.Domain.Entities;
using SA.Domain.Interfaces;

namespace SA.Application.Services
{
    public class ProductService : IProductService
    {
        //private readonly IProductRepository _productRepository;

        //public ProductService(IProductRepository productRepository)
        //{
        //    _productRepository = productRepository;
        //}

        //public async Task<IEnumerable<Product>> GetProductsAsync()
        //{
        //    return await _productRepository.GetAllAsync();
        //}

        //public async Task<Product?> GetProductByIdAsync(int id)
        //{
        //    return await _productRepository.GetByIdAsync(id);
        //}

        //public async Task<Product> CreateProductAsync(Product product)
        //{
        //    // Aquí podrías agregar validaciones de negocio antes de guardar
        //    // Ejemplo: if (product.Price < 0) throw new Exception("Precio inválido");
        //    return await _productRepository.AddAsync(product);
        //}

        //public async Task UpdateProductAsync(Product product)
        //{
        //    await _productRepository.UpdateAsync(product);
        //}

        //public async Task DeleteProductAsync(int id)
        //{
        //    await _productRepository.DeleteAsync(id);
        //}
        private readonly IProductRepository _productRepository;
        private readonly INotificationService _notificationService;

        public ProductService(IProductRepository productRepository, INotificationService notificationService)
        {
            _productRepository = productRepository;
            _notificationService = notificationService;
        }

        public async Task<IEnumerable<ProductDto>> GetProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();

            // Mapeo manual (Entity -> DTO)
            return products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            });
        }

        public async Task<ProductDto?> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) return null;

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }

        public async Task<ProductDto> CreateProductAsync(CreateProductDto productDto)
        {
            // Mapeo inverso (DTO -> Entity) para guardar en BD
            var newProductEntity = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price
            };

            var createdProduct = await _productRepository.AddAsync(newProductEntity);
             
            // Devolvemos el DTO resultante (con el ID generado)
            var resultDto = new ProductDto
            {
                Id = createdProduct.Id,
                Name = createdProduct.Name,
                Price = createdProduct.Price
            };

            // ¡AVISAMOS A TODOS!
            await _notificationService.NotifyProductChanged(resultDto, "Create");

            return resultDto;
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }
    }
}