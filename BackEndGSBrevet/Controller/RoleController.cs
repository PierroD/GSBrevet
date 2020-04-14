using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEndGSBrevet;
using BackEndGSBrevet.Models;
using BackEndGSBrevet.Repositories;
using PLogger;

namespace BackEndGSBrevet.Controller
{
    public class RoleController : Controller
    {
        public static IEnumerable<Role> getAll()
        {
            if (Auth.Role().id == 2)
            {
                Log.Infos("Retourne tous les roles");
                return unitOfWork.Roles.GetAll();
            }
            else
                return null;
        }

        public static Role getById(int id)
        {
            if (Auth.Role().id == 2)
            {
                Log.Infos($"Retourne le role qui a pour Id : {id}");
                return unitOfWork.Roles.FirstOrDefault(r => r.id == id);
            }
            else
                return null;
        }

        public static int getByLibelle(string libelle)
        {
            if (Auth.Role().id == 2)
            {
                return unitOfWork.Roles.FirstOrDefault(r => r.libelle == libelle).id;
            }
            else
                return 0;
        }

    }
}
