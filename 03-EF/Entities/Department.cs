using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EF.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly HiringDate { get; set; }

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        [ForeignKey(nameof(Manager))]
        public int? ManagerId { get; set; }
        [InverseProperty(nameof(Instructor.ManageDepartment))]
        public Instructor Manager { get; set; }
        [InverseProperty(nameof(Instructor.WorkDepartment))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }
}
