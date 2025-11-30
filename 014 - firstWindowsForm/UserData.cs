using _014___firstWindowsForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014___firstWindowsForm
{
    public class UserData
    {
        public static List<UserLogin> Users = new List<UserLogin>()
    {
        new UserLogin() { userName = "admin", Pass = "1234" },
        new UserLogin() { userName = "admin2", Pass = "5678" }
    };
    }
}
