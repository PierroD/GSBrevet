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
            if (Auth.Role().id == 2)
            {
                Log.Infos("Retourne tous les utilisateurs");
                return unitOfWork.Users.GetAll();
            }
            else
                return null;
        }

        public static User FirstOrDefault(int id)
        {
            if (Auth.Role().id == 2) // 2 is admin
            {
                Log.Infos($"Retourne l'utilisateur qui a pour Id : {id}");
                return unitOfWork.Users.Get(id);
            }
            else
                return null;
        }
        public static void UpdateUser(int id, string last_name, string first_name, string username, string password, DateTime birth_date, int role_id)
        {
            unitOfWork.Users.Update(c => c.id == id, new User
            {
                id = id,
                last_name = last_name,
                first_name = first_name,
                username = username,
                password = (password.Contains("$2a") ? password : BCrypt.Net.BCrypt.HashPassword(password)),
                birth_date = birth_date,
                role_id = role_id
            });
            Log.Infos($"On met à jour un utilisateur qui a pour Id : {id}");
        }
        public static void AddUser(string last_name, string first_name, string username, string password, DateTime birth_date, int role_id)
        {
            unitOfWork.Users.Add(new User
            {
                last_name = last_name,
                first_name = first_name,
                username = username,
                password = (password.Contains("$2a") ? password : BCrypt.Net.BCrypt.HashPassword(password)),
                birth_date = birth_date,
                role_id = role_id
            });
            Log.Infos($"On ajoute un nouvel utilisateur");
        }

        public static void Delete(int id)
        {
            if (Auth.Role().id == 2) // 2 is admin
            {
                User delete_user = unitOfWork.Users.FirstOrDefault(r => r.id == id);
                unitOfWork.Users.Remove(delete_user);
                Log.Infos($"L'utilisateur nommée : {delete_user.last_name} {delete_user.first_name} a correctement été supprimée");
            }
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
                    Role role = unitOfWork.Roles.FirstOrDefault(u => u.id == user.role_id);
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
