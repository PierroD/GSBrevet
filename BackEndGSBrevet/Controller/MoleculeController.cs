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
    public class MoleculeController : Controller
    {
        public static IEnumerable<Molecule> getAll()
        {
            return unitOfWork.Molecules.GetAll();
        }
        public static Molecule getById(int id)
        {
            return unitOfWork.Molecules.FirstOrDefault(m => m.id == id);
        }

        public static void AddMolecule(string generic_name, string real_name, string formula)
        {
            unitOfWork.Molecules.Add(new Molecule
            {
                generic_name = generic_name,
                real_name = real_name,
                formula = formula
            });
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
        }

        public static bool MoleculeUsed(int id)
        {
            Patent usedby_patent = unitOfWork.Patents.FirstOrDefault(m => m.molecule_id == id);
            Utility usedby_utility = unitOfWork.Utilities.FirstOrDefault(m => m.molecule_id == id);
            if (usedby_patent != null && usedby_utility != null)
                return true;
            else
                return false;
        }

        public static void Delete(int id)
        {
            Molecule delete_molecule = unitOfWork.Molecules.FirstOrDefault(m => m.id == id);
            unitOfWork.Molecules.Remove(delete_molecule);
        }
    }
}
