using BackEndGSBrevet;
using BackEndGSBrevet.Repositories.Interfaces;

namespace BackEndGSBrevet.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GSBrevetDbContext _context;

        public UnitOfWork(GSBrevetDbContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Roles = new RoleRepository(_context);
        }

        public IUserRepository Users { get; private set; }
        public IRoleRepository Roles { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}