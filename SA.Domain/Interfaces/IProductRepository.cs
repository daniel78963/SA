using SA.Domain.Entities;

namespace SA.Domain.Interfaces
{
    ///Aquí definimos las interfaces ("contratos") que la infraestructura debe cumplir. No hay dependencias de EF Core ni de la Web aquí.
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task<Product> AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}
