using PPCOM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//IMPORTANT
using PPCOM.Models;
//IMPORTANT

namespace PPCOM.Services
{
    public class UserService
    {
        private UserRepository repo = new UserRepository();

        public List<User> GetEmployees()
        {
            return repo.GetEmployees();
        }
    }
}
