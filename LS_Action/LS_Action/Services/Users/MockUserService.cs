using LS_Action.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LS_Action.Services
{
    public class MockUserService : IUserService
    {
        public bool Authenticate(Users authenticateUser, out Users authenticatedUser)
        {
            authenticatedUser = null;
            
            if(!string.IsNullOrEmpty(authenticateUser.username) &&
               !string.IsNullOrEmpty(authenticateUser.password))
            {
                authenticatedUser = new Users
                {
                    username = authenticateUser.username,
                    password = authenticateUser.password,
                    fullname = "Dương Nguyễn Tấn Hòa",
                    avartar = "https://st4.depositphotos.com/4329009/19956/v/380/depositphotos_199564354-stock-illustration-creative-vector-illustration-default-avatar.jpg",
                    email = "erp.hoa@leadingstar.com.vn",
                    phone = "0359759402"
                };
                return true;
            }

            return false;
        }
    }
}
