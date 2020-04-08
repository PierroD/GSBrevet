using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEndGSBrevet.Models;

namespace BackEndGSBrevet.Controller
{
    public class Auth
    {
        private static User user=null;
        private static Role role = null;
        private static bool auth=false;
        public Auth(User u, Role r)
        {
            user = u;
            role = r;
            auth = true;
        }
        public static bool True()
        {
            return auth;
        }

        public static User User()
        {
            return user;
        }
        public static Role Role()
        {
            return role;
        }
        public static void destroy()
        {
            user = null;
            role = null;
            auth = false;
        }


    }
}
