using System.Data.Entity;
using System.Linq;
using BackEndGSBrevet;
using BackEndGSBrevet.Models;
using BackEndGSBrevet.Repositories;
using BackEndGSBrevet.Repositories.Interfaces;

namespace BackEndGSBrevet.Repositories
{
    public class PatentRepository : Repository<Patent>, IPatentRepository
    {
        public PatentRepository(GSBrevetDbContext context) : base(context)
        {
        }

        public GSBrevetDbContext GSBContext
        {
            get { return Context as GSBrevetDbContext; }
        }
    }
}