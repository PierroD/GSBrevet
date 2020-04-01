using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEndGSBrevet;
using BackEndGSBrevet.Models;
using BackEndGSBrevet.Repositories;

namespace BackEndGSBrevet.Controller
{
    public class ContractController : Controller
    {
        public static IEnumerable<Contract> getAll()
        {
            return unitOfWork.Contracts.GetAll();
        }

    }
}
