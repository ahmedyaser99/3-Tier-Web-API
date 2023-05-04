using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IInstructorManager
    {
        IEnumerable<InstructorDTO> GetAll();
        InstructorDTO GetById(int Id);
        public void Insert(InstructorDTO instructor);
    }
}
