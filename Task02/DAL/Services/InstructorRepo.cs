using DAL.Context;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class InstructorRepo : IInstructorRepository
    {
        private readonly Task02Context Context;
        public InstructorRepo(Task02Context context)
        {
            Context = context;
        }
        public List<Instructor> GetAll()
        {
            return Context.Instructors.Include("Department").ToList();
        }

        public Instructor GetDetails(int Id)
        {
            return Context.Instructors.Include("Department").FirstOrDefault(p => p.Id == Id);
        }

        public void Insert(Instructor instructor)
        {
            Context.Instructors.Add(instructor);
            Context.SaveChanges();
        }
        public int UpdateInstructor(int id, Instructor instructor)
        {
            Context.Instructors.Update(instructor);
            int raw = Context.SaveChanges();
            return raw;
        }
        public void DeleteInstructor(int id)
        {
            Context.Remove(Context.Instructors.Find(id));
            Context.SaveChanges();
        }

        public List<Instructor> GetInstructorByDepartmentId(int id)
        {
            return Context.Instructors.Where(e => e.DepartmentId == id).ToList();
        }
    }
}