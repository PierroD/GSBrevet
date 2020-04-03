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
    public class UtilityController : Controller
    {
        public static IEnumerable<Utility> getAll()
        {
            return unitOfWork.Utilities.GetAll();
        }
        public static Utility getById(int id)
        {
            return unitOfWork.Utilities.FirstOrDefault(m => m.id == id);
        }

        public static void AddUtility(int molecule_id, string name, string description)
        {
            unitOfWork.Utilities.Add(new Utility
            {
                molecule_id = molecule_id,
                name = name,
                description = description
            });
        }

        public static void UpdateUtility(int id, int molecule_id, string name, string description)
        {
            unitOfWork.Utilities.Update(m => m.id == id, new Utility
            {
                id = id,
                molecule_id = molecule_id,
                name = name,
                description = description
            });
        }

        public static void Delete(int id)
        {
            Utility delete_utility = unitOfWork.Utilities.FirstOrDefault(u => u.id == id);
            unitOfWork.Utilities.Remove(delete_utility);
        }
    }
}
