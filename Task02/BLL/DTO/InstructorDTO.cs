using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class InstructorDTO
    {
        public int InstructorId { get; set; }
        public string? Instructor_Name { get; set; }
        public int? Age { get; set; }
        public string? Department_Name { get; set; }
        //public int Dept_Id { get; set; }
    }
}
