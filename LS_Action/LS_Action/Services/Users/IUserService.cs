using LS_Action.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LS_Action.Services
{
    public interface IUserService
    {
        bool Authenticate(Users authenticateUser, out Users authenticatedUser);
    }
}
