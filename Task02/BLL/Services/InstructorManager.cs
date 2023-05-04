using BLL.DTO;
using DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class InstructorManager : IInstructorManager
    {
        IInstructorRepository repo;
        public InstructorManager(IInstructorRepository _repo)
        {
            repo = _repo;
        }
        public IEnumerable<InstructorDTO> GetAll()
        {
            var emps = repo.GetAll();
            List<InstructorDTO> instructors = new List<InstructorDTO>();
            foreach (var item in emps)
            {
                InstructorDTO em = new InstructorDTO()
                {
                    InstructorId = item.Id,
                    Age = item.Age,
                    Instructor_Name = item.Name,
                    Department_Name = item.Department.Name
                };
                instructors.Add(em);
            }
            return instructors;
        }

        public InstructorDTO GetById(int Id)
        {
            InstructorDTO ins = new InstructorDTO();
            var insfromDB = repo.GetDetails(Id);
            if (insfromDB != null)
            {
                ins.InstructorId = insfromDB.Id;
                ins.Age = insfromDB.Age;
                ins.Instructor_Name = insfromDB.Name;
                ins.Department_Name = insfromDB.Department.Name;
            }
            return ins;
        }

        public void Insert(InstructorDTO instructor)
        {
            throw new NotImplementedException();
        }
    }
}
