﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendance.Models.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
    }
}
