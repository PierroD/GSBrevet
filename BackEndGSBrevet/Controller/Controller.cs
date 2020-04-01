using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEndGSBrevet.Repositories;

namespace BackEndGSBrevet.Controller
{
   public class Controller
    {
        protected static UnitOfWork unitOfWork = new UnitOfWork(new GSBrevetDbContext());
    }
}
