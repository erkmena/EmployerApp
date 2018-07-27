using EmployerApp.Data.Infrastructure;
using EmployerApp.Model.Models;
using System;
using System.Collections.Generic;

namespace EmployerApp
{
    class Program
    {

        static IQuery _queryHelper;
        static string connectionString;




        static void Main(string[] args)
        {
            connectionString = ConnectionString.EmployerAppConnectionString();
            _queryHelper = new QueryExtension();
            const string query = "Select * FROM Employees";
            List<EmployeeModel> employeeList = _queryHelper.GetEmployees(query, connectionString);
            Console.Read();
        }
    }
}
