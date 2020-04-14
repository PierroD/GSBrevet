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
    public class CompanyController : Controller
    {
        public static IEnumerable<Company> getAll()
        {
            Log.Infos("Retourne toutes les entreprises");
            return unitOfWork.Companies.GetAll();
        }
        public static Company getById(int id)
        {
            Log.Infos($"Retourne l'entreprise qui a pour Id : {id}");
            return unitOfWork.Companies.FirstOrDefault(c => c.id == id);
        }

        public static int getByName(string name)
        {
            Log.Infos($"Retourne l'id de l'entreprise qui a pour Nom : {name}");
            return unitOfWork.Companies.FirstOrDefault(c => c.name == name).id;
        }

        public static void AddCompany(string name, string address, string city, string zip_code)
        {
            unitOfWork.Companies.Add(new Company
            {
                name = name,
                address = address,
                city = city,
                zip_code = zip_code
            });
            Log.Infos($"On ajoute une nouvelle entreprise qui a pour Nom : {name}");
        }

        public static void UpdateCompany(int id, string name, string address, string city, string zip_code)
        {
            unitOfWork.Companies.Update(m => m.id == id, new Company
            {
                id = id,
                name = name,
                address = address,
                city = city,
                zip_code = zip_code
            });
            Log.Infos($"On met à jour une entreprise qui a pour Id : {id} et pour Nom : {name}");
        }

        public static bool CompanyUsed(int id)
        {
            Patent usedby_patent = unitOfWork.Patents.FirstOrDefault(c => c.company_id == id);
            Contract usedby_contract = unitOfWork.Contracts.FirstOrDefault(c => c.company_id == id);
            if (usedby_patent != null && usedby_contract != null)
            {
                Log.Error($"L'entreprise est encore raccrochée à {"un contrat : " + usedby_contract.id} {"un brevet : " + usedby_patent.id}");
                return false;
            }
            else
            {
                Log.Infos("L'entreprise peut être supprimé");
                return true;
            }
        }

        public static void Delete(int id)
        {
            Company delete_company = unitOfWork.Companies.FirstOrDefault(c => c.id == id);
            unitOfWork.Companies.Remove(delete_company);
            Log.Infos($"L'entreprise nommée : {delete_company.name} a correctement été supprimée");
        }
    }

}
