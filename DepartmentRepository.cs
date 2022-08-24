using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPractices
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _conn;

        public DepartmentRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        

        public IEnumerable<Department> GetAllDepartments()
        {
            return _conn.Query<Department>("Select * FROM departments;");
        }

        public void CreateDepartment(string Name)
        {
            throw new NotImplementedException();
        }
    }
}