using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace TestTaskKosta
{
    public class DataAccess
    {
        public List<Employee> GetEmployees(string surName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Connection("TestDB")))
            {
                var output = connection.Query<Employee>($"SELECT * FROM Employee").ToList();
                
                return output;
            }
        }

        public List<Department> GetOrgStructure()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Connection("TestDB")))
            {
                var output = connection.Query<Department>($"SELECT DISTINCT Name, Position FROM Department, Employee").ToList();

                return output;
            }
        }


        public List<Department> GetDepartmentName()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Connection("TestDB")))
            {
                var output = connection.Query<Department>($"SELECT DISTINCT Name FROM Department").ToList();

                return output;
            }
        }
    }
}
