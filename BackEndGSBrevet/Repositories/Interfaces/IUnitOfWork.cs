using System;
using BackEndGSBrevet;

namespace BackEndGSBrevet.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IRoleRepository Roles { get; }
        ICompanyRepository Companies { get; }
        IPatentRepository Patents { get; }   
        IMoleculeRepository Molecules { get; }   
        IContractRepository Contracts { get; }   
    }
}