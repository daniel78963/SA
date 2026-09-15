namespace SA.APILibrary
{
    public class TransientService
    {
        public Guid Id { get; set; }

        public TransientService()
        {
            Id = Guid.NewGuid();
        }

        public Guid GetGuid => Id;
    }

    public class ScopedService
    {
        public Guid Id { get; set; }
        public ScopedService()
        {
            Id = Guid.NewGuid();
        }
        public Guid GetGuid => Id;
    } 

    public class SingletonService
    {
        public Guid Id { get; set; }

        public SingletonService()
        {
            Id = Guid.NewGuid();
        }

        public Guid GetGuid => Id;
    }
}
