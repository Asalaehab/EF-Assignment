using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Models
{
    public class Student
    {
        [Key]
        public int stud_Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public string Address { get; set; }
        public int Age { get; set; }

        public int StudentDepartmentId { get; set; }

        public Department StudentDepartment { get; set; } = null!;


        public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
    }
}
