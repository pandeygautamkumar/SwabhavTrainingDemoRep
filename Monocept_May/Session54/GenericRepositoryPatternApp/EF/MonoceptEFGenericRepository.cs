namespace GenericRepositoryPatternApp.EF
{
    public class MonoceptEFGenericRepository<T> : IRepository<T>
       where T : class
    {
        private readonly OrganizationDBContext _db;
        public MonoceptEFGenericRepository(OrganizationDBContext context)
        {
            _db=context;
        }
        public void Add(T entity)
        {
            _db.Set<T>().Add(entity);
            _db.SaveChanges();
        }

        public IQueryable<T> Get()
        {
            return _db.Set<T>();
        }
    }
}
