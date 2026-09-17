using SA.APILibrary.Entities;

namespace SA.APILibrary.Interfaces
{
    public interface IRepositoryValues
    {
        void AddValue(Values value);
        IEnumerable<Values> GetValues();
    }
}
