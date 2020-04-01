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
    public class PatentController : Controller
    {
        public static IEnumerable<Patent> getAll()
        {
            return unitOfWork.Patents.GetAll();
        }
        public static Patent getById(int id)
        {
            return unitOfWork.Patents.FirstOrDefault(p => p.id == id);
        }

    }
}
