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
    public class UserController
    {
        private static UnitOfWork unitOfWork = new UnitOfWork(new GSBrevetDbContext());
        public static IEnumerable<User> getAll()
        {
            return unitOfWork.Users.GetAll();
        }

        public static User find(int id)
        {
            return unitOfWork.Users.Get(id);
        }
        public static async Task<IEnumerable<User>> getAllAsync()
        {
            return await unitOfWork.Users.GetAllAsync();
        }

        /*  
                public static ticket find(int id)
                {
                    ticket t = gsbapp.ticket.Find(id);
                    return t;
                }
                public static void create(ticket t)
                {
                    gsbapp.ticket.Add(t);
                    gsbapp.SaveChanges();
                }
                public static void delete(int id)
                {
                    ticket t = gsbapp.ticket.Find(id);
                    gsbapp.ticket.Remove(t);
                }*/


    }
}
