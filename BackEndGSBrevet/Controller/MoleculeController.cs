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

    }
}
