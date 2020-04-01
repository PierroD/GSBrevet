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
    public class UserController : Controller
    {
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

        public static (bool, string, int) signIn(string Username, string Password)
        {
            var user = unitOfWork.Users.FirstOrDefault(u => u.username == Username);
            if (user != null)
            {
                if (user.password == Password)
                {
                    switch (unitOfWork.Roles.FirstOrDefault(u => u.id == user.id).id)
                    {
                        case 1:
                            return (true, "Vous êtes connecté en tant qu'utilisateur", 1);
                        case 2:
                            return (true, "Vous êtes connecté en tant qu'administrateur", 2);
                        default:
                            return (true, "Vous êtes connecté en tant qu'utilisateur", 1);
                    }
                }
                else
                {
                    return (false, "Le mot de passe est incorrect", 0);
                }
            }
            else
            {
                return (false, "L'identifiant est incorrect", 0);
            }

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
