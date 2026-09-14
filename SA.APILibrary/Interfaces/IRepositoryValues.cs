using SA.APILibrary.Entities;

namespace SA.APILibrary.Interfaces
{
    public interface IRepositoryValues
    {
        IEnumerable<Values> GetValues();
    }
}
