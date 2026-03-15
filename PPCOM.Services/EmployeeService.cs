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
    public class EmployeeService
    {
        private EmployeeRepository repo = new EmployeeRepository();

        public List<Employee> GetEmployees()
        {
            return repo.GetEmployees();
        }
    }
}
