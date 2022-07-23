using Microsoft.AspNetCore.Mvc;
using ProjectPRN211.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPRN211.Logics
{
    public class AccountManager : Controller
    {
        TestContext _context;
        public AccountManager()
        {
            _context = new TestContext();
        }

        public Account GetAcc(string user, string pass)
        {
            return _context.Accounts.FirstOrDefault(x => x.Username.ToLower().Equals(user.ToLower()) && x.Password.ToLower().Equals(pass.ToLower()));
        }
    }
}
