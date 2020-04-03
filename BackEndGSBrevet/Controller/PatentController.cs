using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
        public static int getByNumber(string number)
        {
            return unitOfWork.Patents.FirstOrDefault(p => p.number == number).id;
        }

        public static void AddPatent(int molecule_id, int company_id, string country, string number, DateTime deposit_date, int duration)
        {
            unitOfWork.Patents.Add(new Patent
            {
                molecule_id = molecule_id,
                company_id = company_id,
                country = country,
                number = $"GSB{number}",
                deposit_date = deposit_date, // deposit_date ,//.ToString("yyyy-MM-dd"),
                duration = duration
            });
        }

        public static void UpdatePatent(int id, int molecule_id, int company_id, string country, string number, DateTime deposit_date, int duration)
        {
            unitOfWork.Patents.Update(p => p.id == id, new Patent
            {
                id = id,
                molecule_id = molecule_id,
                company_id = company_id,
                country = country,
                number = $"GSB{number}",
                deposit_date = deposit_date,
                duration = duration
            });
        }

        public static bool PatentUsed(int id)
        {
            Contract usedby_contract = unitOfWork.Contracts.FirstOrDefault(c => c.patent_id == id);
            if (usedby_contract != null)
                return false;
            else
                return true;
        }

        public static void Delete(int id)
        {
            Patent delete_patent = unitOfWork.Patents.FirstOrDefault(p => p.id == id);
            unitOfWork.Patents.Remove(delete_patent);
        }

    }
}
