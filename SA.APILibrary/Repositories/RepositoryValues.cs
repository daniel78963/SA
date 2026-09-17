using SA.APILibrary.Entities;
using SA.APILibrary.Interfaces;

namespace SA.APILibrary.Repositories
{
    public class RepositoryValues : IRepositoryValues
    {
        public void AddValue(Values value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Values> GetValues()
        {
            return new List<Values>
            {
                new Values { Id = 1, Name = "Value 1" },
                new Values { Id = 2, Name = "Value 2" }
            };
        }
    }
}
