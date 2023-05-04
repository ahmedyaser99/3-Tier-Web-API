using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using DAL.Models;

namespace DAL.Services
{
    public class DepartmentRepo : IDepartmentRepository
    {
        private readonly Task02Context Context;
        public DepartmentRepo(Task02Context context)
        {
            Context = context;
        }
        public List<Department> GetAll()
        {
            return Context.Departments.ToList();
        }

        public Department GetDetails(int id)
        {
            return Context.Departments.Find(id);
        }

        public void Insert(Department department)
        {
            Context.Departments.Add(department);
            Context.SaveChanges();
        }

        public int UpdateDepartment(int id, Department department)
        {
            Department departmentUpdated = Context.Departments.FirstOrDefault(s => s.Id == id);
            departmentUpdated.Name = department.Name;
            departmentUpdated.Location = department.Location;
            departmentUpdated.Branches = department.Branches;
            departmentUpdated.Description = department.Description;
            int raw = Context.SaveChanges();
            return raw;
        }
        public void DeleteDepartment(int id)
        {
            Context.Remove(Context.Departments.Find(id));
            Context.SaveChanges();
        }

    }
}
