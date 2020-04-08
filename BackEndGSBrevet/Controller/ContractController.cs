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
    public class ContractController : Controller
    {
        public static IEnumerable<Contract> getAll()
        {
            Log.Infos("Retourne tous les contrats");
            return unitOfWork.Contracts.GetAll();
        }

        public static IEnumerable<Contract> getByCompany(int id)
        {
            Log.Infos($"Retourne tous les contracts qui on appartiennent à l'entreprise qui a pour id : {id}");
            return unitOfWork.Contracts.GetAll().Where(c => c.company_id == id);
        }

        public static (int, int) getYears()
        {
            Log.Infos("Retourne la plus petite et la plus grande année dans les contrats");
            int minYear = unitOfWork.Contracts.GetAll().Min(c => c.create_date).Year;
            int maxYear = unitOfWork.Contracts.GetAll().Max(c => c.create_date).Year;
            return (minYear, maxYear);
        }
        public static double getPriceFromMonth(int year, int month)
        {
            Log.Infos($"Retourne la somme des contrats en fonction de l'année({year}) et du mois({month})");
            return unitOfWork.Contracts.GetAll().Where(c => c.create_date.Year == year && c.create_date.Month == month).Sum(c => c.price);
        }

        public static void UpdateContract(int id, int company_id, int patent_id, DateTime create_date, int duration, double price)
        {
            unitOfWork.Contracts.Update(c => c.id == id, new Contract
            {
                id = id,
                company_id = company_id,
                patent_id = patent_id,
                create_date = create_date,
                duration = duration,
                price = price
            });
            Log.Infos($"On met à jour un contrat qui a pour Id : {id}");
        }
        public static void AddContract(int company_id, int patent_id, DateTime create_date, int duration, double price)
        {
            unitOfWork.Contracts.Add(new Contract
            {
                company_id = company_id,
                patent_id = patent_id,
                create_date = create_date,
                duration = duration,
                price = price
            });
            Log.Infos($"On ajoute un nouveau contrat");
        }

        public static void Delete(int id)
        {
            Contract delete_contract = unitOfWork.Contracts.FirstOrDefault(c => c.id == id);
            unitOfWork.Contracts.Remove(delete_contract);
            Log.Infos($"Le contrat d'Id : {delete_contract.id} a correctement été supprimé");
        }

    }
}
