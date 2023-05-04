using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        //[MaxLength(20)]
        public int SSN { get; set; }
        [MaxLength(40)]
        public string? Name { get; set; }
        [MaxLength(40)]
        public string? Address { get; set; }
        public int? Age { get; set; }
        //[DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
        //[DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        //[DataType(DataType.Password)]
        public string? Password { get; set; }
        public DateTime DOB { get; set; } = DateTime.Now;
        [ForeignKey("Department")]
        public virtual int? DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
    }
}
