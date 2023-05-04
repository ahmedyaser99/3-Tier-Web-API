using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public interface IInstructorRepository
    {
        public List<Instructor> GetAll();
        public Instructor GetDetails(int Id);
        public void Insert(Instructor instructor);
        public int UpdateInstructor(int id, Instructor instructor);
        public void DeleteInstructor(int id);
        public List<Instructor> GetInstructorByDepartmentId(int id);
    }
}
