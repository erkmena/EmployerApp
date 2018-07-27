using EmployerApp.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployerApp.Data.Infrastructure
{
    public interface IQuery
    {
        List<EmployeeModel> GetEmployees(string query, string connectionString);
    }
}
