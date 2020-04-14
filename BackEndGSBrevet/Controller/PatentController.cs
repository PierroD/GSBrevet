using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEndGSBrevet;
using BackEndGSBrevet.Models;
using BackEndGSBrevet.Repositories;
using PLogger;

namespace BackEndGSBrevet.Controller
{
    public class PatentController : Controller
    {
        public static IEnumerable<Patent> getAll()
        {
            Log.Infos("Retourne tous les brevets");
            return unitOfWork.Patents.GetAll();
        }
        public static Patent getById(int id)
        {
            Log.Infos($"Retourne le brevet qui a pour Id : {id}");
            return unitOfWork.Patents.FirstOrDefault(p => p.id == id);
        }
        public static int getByNumber(string number)
        {
            Log.Infos($"Retourne l'id du brevet qui a pour Nombre : {number}");
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
                deposit_date = deposit_date,
                duration = duration
            });
            Log.Infos($"On ajoute un nouveau brevet qui a pour Numéro : GSB{number}");
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
            Log.Infos($"On met à jour un brevet qui a pour Id : {id} et pour Numéro : GSB{number}");
        }

        public static bool PatentUsed(int id)
        {
            Contract usedby_contract = unitOfWork.Contracts.FirstOrDefault(c => c.patent_id == id);
            if (usedby_contract != null)
            {
                Log.Error($"Le brevet est encore raccrochée à {"un contrat : " + usedby_contract.id}");
                return false;
            }
            else
            {
                Log.Infos("Le brevet peut être supprimé");
                return true;
            }
        }

        public static void Delete(int id)
        {
            Patent delete_patent = unitOfWork.Patents.FirstOrDefault(p => p.id == id);
            unitOfWork.Patents.Remove(delete_patent);
            Log.Infos($"Le brevet nommé : {delete_patent.number} a correctement été supprimé");
        }

    }
}
