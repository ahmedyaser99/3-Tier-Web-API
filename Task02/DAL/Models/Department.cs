using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public enum Branches { Cairo, Alex, Mansoura}
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        public string? Name { get; set; } = String.Empty;
        [MaxLength(20)]
        public string? Location { get; set; }
        [EnumDataType(typeof(Branches))]
        public Branches? Branches { get; set; }
        [MaxLength(40)]
        public string? Description { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }
}
