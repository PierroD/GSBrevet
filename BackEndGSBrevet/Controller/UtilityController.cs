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
    public class UtilityController : Controller
    {
        public static IEnumerable<Utility> getAll()
        {
            Log.Infos("Retourne toutes les utilitées");
            return unitOfWork.Utilities.GetAll();
        }
        public static Utility getById(int id)
        {
            Log.Infos($"Retourne l'utilitée qui a pour Id : {id}");
            return unitOfWork.Utilities.FirstOrDefault(m => m.id == id);
        }

        public static IEnumerable<Utility> getByMolecule(int id)
        {
            Log.Infos($"Retourne tous les utilitées qui on appartiennent à la molécule qui a pour id : {id}");
            return unitOfWork.Utilities.GetAll().Where(c => c.molecule_id == id);
        }

        public static void AddUtility(int molecule_id, string name, string description)
        {
            unitOfWork.Utilities.Add(new Utility
            {
                molecule_id = molecule_id,
                name = name,
                description = description
            });
            Log.Infos($"On ajoute une nouvelle utilitée qui a pour Nom : {name}");
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
            Log.Infos($"On met à jour une entreprise qui a pour Id : {id} et pour Nom : {name}");
        }

        public static void Delete(int id)
        {
            Utility delete_utility = unitOfWork.Utilities.FirstOrDefault(u => u.id == id);
            unitOfWork.Utilities.Remove(delete_utility);
            Log.Infos($"L'utilitée nommée : {delete_utility.name} a correctement été supprimée");
        }
    }
}
