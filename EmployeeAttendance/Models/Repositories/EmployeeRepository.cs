using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeAttendance.Models.Interfaces;

namespace EmployeeAttendance.Models.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeesEntities _empContext;

        public EmployeeRepository(EmployeesEntities context)
        {
            this._empContext = context;
        }

        public List<Employee> GetAllEmployees()
        {
            return this._empContext.Employees.ToList<Employee>();
        }
    }
}