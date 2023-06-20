namespace GenericRepositoryPatternApp.EF
{
    public class MonoceptEFGenericRepository<T> : IRepository<T> where T : class
    {
        private readonly OrganizationDbContext _organizationDbContext;

        public MonoceptEFGenericRepository(OrganizationDbContext organizationDbContext)
        {
            _organizationDbContext = organizationDbContext;
        }
        public void Add(T entity)
        {
            _organizationDbContext.Set<T>().Add(entity);
            _organizationDbContext.SaveChanges();
        }

        public IQueryable<T> Get()
        {
            return _organizationDbContext.Set<T>();
        }
    }
}
