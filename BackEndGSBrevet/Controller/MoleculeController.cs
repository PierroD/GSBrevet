using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEndGSBrevet;
using BackEndGSBrevet.Models;
using PLogger;
using BackEndGSBrevet.Repositories;

namespace BackEndGSBrevet.Controller
{
    public class MoleculeController : Controller
    {
        public static IEnumerable<Molecule> getAll()
        {
            Log.Infos("Retourne tous les molécules");
            return unitOfWork.Molecules.GetAll();
        }
        public static Molecule getById(int id)
        {
            Log.Infos($"Retourne la molécule qui a pour Id : {id}");
            return unitOfWork.Molecules.FirstOrDefault(m => m.id == id);
        }

        public static int getByName(string real_name)
        {
            Log.Infos($"Retourne l'id de la molécule qui a pour Nom : {real_name}");
            return unitOfWork.Molecules.FirstOrDefault(m => m.real_name == real_name).id;
        }

        public static void AddMolecule(string generic_name, string real_name, string formula)
        {
            unitOfWork.Molecules.Add(new Molecule
            {
                generic_name = generic_name,
                real_name = real_name,
                formula = formula
            });
            Log.Infos($"On ajoute une nouvelle molécule qui a pour Nom : {real_name}");
        }

        public static void UpdateMolecule(int id, string generic_name, string real_name, string formula)
        {
            unitOfWork.Molecules.Update(m => m.id == id, new Molecule
            {
                id = id,
                generic_name = generic_name,
                real_name = real_name,
                formula = formula
            });
            Log.Infos($"On met à jour une molécule qui a pour Id : {id} et pour Nom : {real_name}");
        }

        public static bool MoleculeUsed(int id)
        {
            Patent usedby_patent = unitOfWork.Patents.FirstOrDefault(m => m.molecule_id == id);
            Utility usedby_utility = unitOfWork.Utilities.FirstOrDefault(m => m.molecule_id == id);
            if (usedby_patent != null && usedby_utility != null)
            {
                Log.Error($"La molécule est encore raccrochée à {"une utilitée : " + usedby_utility.id} {"un brevet : " + usedby_patent.id}");
                return false;
            }
            else
            {
                Log.Infos("La molécule peut être supprimé");
                return true;
            }
        }

        public static void Delete(int id)
        {
            Molecule delete_molecule = unitOfWork.Molecules.FirstOrDefault(m => m.id == id);
            unitOfWork.Molecules.Remove(delete_molecule);
            Log.Infos($"L'entreprise nommée : {delete_molecule.real_name} a correctement été supprimée");

        }
    }
}
