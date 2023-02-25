using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TicTacToe.Views.Repositories
{
    public class AuthenticateRepository
    {
        private readonly UserManager<IdentityUser> userManger;

        public AuthenticateRepository(UserManager<IdentityUser> userManger)
        {
            this.userManger = userManger;
        }
    }
}