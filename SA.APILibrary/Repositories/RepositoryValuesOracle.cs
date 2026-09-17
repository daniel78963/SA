using SA.APILibrary.Entities;
using SA.APILibrary.Interfaces;

namespace SA.APILibrary.Repositories
{
    public class RepositoryValuesOracle : IRepositoryValues
    {
        private readonly List<Values> values;
        public RepositoryValuesOracle()
        {
            values = new List<Values>
            {
                new() { Id = 3, Name = "Value 3 Oracle" },
                new() { Id = 4, Name = "Value 4 Oracle" },
                new() { Id = 4, Name = "Value 4 Oracle" }
            };
        }

        public IEnumerable<Values> GetValues()
        {
            return values;
        }

        public void AddValue(Values value)
        {
            values.Add(value);
        }
    }
}
