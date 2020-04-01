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
    public class CompanyController : Controller
    {
        public static IEnumerable<Company> getAll()
        {
            return unitOfWork.Companies.GetAll();
        }
        public static Company getById(int id)
        {
            return unitOfWork.Companies.FirstOrDefault(c => c.id == id);
        }
    }

}
