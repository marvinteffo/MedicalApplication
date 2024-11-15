using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    public interface IUserService
    {
        AppUser Register(AppUser user);
        string Login(Login login);
        AppUser GetUserById(int id);
        AppUser UpdateUser(int id, AppUser user);
        bool DeleteUser(int id);
    }
}