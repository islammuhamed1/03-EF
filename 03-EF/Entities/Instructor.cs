using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EF.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Bouns { get; set; }
        public string? Address { get; set; }
        public decimal HourRate { get; set; }

        public ICollection<InstructorCourse> InstructorCourses { get; set; } = new HashSet<InstructorCourse>();
        [InverseProperty(nameof(Department.Manager))]
        public Department ManageDepartment { get; set; }
        public int? DepartmentId { get; set; }
        [InverseProperty(nameof(Department.Instructors))]
        public Department WorkDepartment { get; set; }

    }
}
