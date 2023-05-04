using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public interface IDepartmentRepository
    {
        public List<Department> GetAll();
        public Department GetDetails(int id);
        public void Insert(Department department);
        public int UpdateDepartment(int id, Department department);
        public void DeleteDepartment(int id);
    }
}
