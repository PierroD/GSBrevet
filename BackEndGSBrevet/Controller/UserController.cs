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
    public class UserController : Controller
    {
        public static IEnumerable<User> getAll()
        {
            Log.Infos("Retourne tous les utilisateurs");
            return unitOfWork.Users.GetAll();
        }

        public static User find(int id)
        {
            Log.Infos($"Retourne l'utilisateur qui a pour Id : {id}");
            return unitOfWork.Users.Get(id);
        }
        public static async Task<IEnumerable<User>> getAllAsync() // test des requêtes async
        {
            return await unitOfWork.Users.GetAllAsync();
        }

        public static bool signIn(string username, string password)
        {
            var user = unitOfWork.Users.FirstOrDefault(u => u.username == username);
            if (user != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, user.password))
                {
                    Role role = unitOfWork.Roles.FirstOrDefault(u => u.id == user.id);
                    switch (role.id)
                    {
                        case 1:
                            {
                                Log.Infos($"L'utilisateur {user.last_name + " " + user.first_name} est connecté en tant qu'Utilisateur");
                                new Auth(user, role);
                                return (Auth.True());
                            }
                        case 2:
                            {
                                Log.Infos($"L'utilisateur {user.last_name + " " + user.first_name} est connecté en tant qu'Admin");
                                new Auth(user, role);
                                return (Auth.True());
                            }
                        default:
                            {
                                Log.Infos($"Ne pouvant déterminé le rôle de {user.last_name + " " + user.first_name} il est automatiquement connecté en tant qu'utilisateur");
                                new Auth(user, role);
                                return (Auth.True());
                            }
                    }
                }
                else
                {
                    Log.Error($"L'utilisateur {user.last_name + " " + user.first_name} : a rentré un identifiant incorrect");
                    return (Auth.True());
                }
            }
            else
            {
                Log.Error($"L'identifiant renseigné {username} est incorrect");
                return (Auth.True());
            }

        }
    }
}
