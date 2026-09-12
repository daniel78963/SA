using SA.APILibrary.Entities;

namespace SA.APILibrary.Repositories
{
    public class RepositoryValues()
    {
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
