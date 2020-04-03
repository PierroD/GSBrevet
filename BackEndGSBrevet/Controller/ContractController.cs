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
    public class ContractController : Controller
    {
        public static IEnumerable<Contract> getAll()
        {
            return unitOfWork.Contracts.GetAll();
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
        }

        public static void Delete(int id)
        {
            Contract delete_contract = unitOfWork.Contracts.FirstOrDefault(c => c.id == id);
            unitOfWork.Contracts.Remove(delete_contract);
        }

    }
}
