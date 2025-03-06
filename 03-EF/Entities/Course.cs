using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EF.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Duration { get; set; }
        public string? Description { get; set; }

        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();
        [ForeignKey(nameof(Topic))]
        public int? TopicId { get; set; }
        public Topic Topic { get; set; }
        public ICollection<InstructorCourse> InstructorCourses { get; set; } = new HashSet<InstructorCourse>();
    }
}
