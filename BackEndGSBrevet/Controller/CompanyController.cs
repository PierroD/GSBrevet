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
    public class CompanyController : Controller
    {
        public static IEnumerable<Company> getAll()
        {
            return unitOfWork.Companies.GetAll();
        }
        public static Company getById(int id)
        {
            return unitOfWork.Companies.FirstOrDefault(c => c.id == id);
        }

        public static int getByName(string name)
        {
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
        }

        public static bool CompanyUsed(int id)
        {
            Patent usedby_patent = unitOfWork.Patents.FirstOrDefault(c => c.company_id == id);
            Contract usedby_contract = unitOfWork.Contracts.FirstOrDefault(c => c.company_id == id);
            if (usedby_patent != null && usedby_contract != null)
                return false;
            else
                return true;
        }

        public static void Delete(int id)
        {
            Company delete_company = unitOfWork.Companies.FirstOrDefault(c => c.id == id);
            unitOfWork.Companies.Remove(delete_company);
        }
    }

}
