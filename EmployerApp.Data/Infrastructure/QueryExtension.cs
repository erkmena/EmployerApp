using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using EmployerApp.Model.Models;
using Dapper;
namespace EmployerApp.Data.Infrastructure
{
    public class QueryExtension : IQuery
    {
        public List<EmployeeModel> GetEmployees(string query, string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection.Query<EmployeeModel>(query).AsList();
        }

    }
}
