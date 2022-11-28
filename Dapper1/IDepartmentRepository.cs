using System;
using System.Data;

namespace Dapper1
{
    public interface IDepartmentRepository
    {
       
        public IEnumerable<Department> GetAllDepartments();
        public void InsertDepartment(string newDepartmentName);
    }
}

