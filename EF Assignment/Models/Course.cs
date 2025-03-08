using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Models
{
    public class Course
    {
        [Key]
        public int crs_Id { get; set; }//Pk
        public int Duration { get; set; }

        [Required]
        public string Name { get; set; }

      
        public string? Description { get; set; }
        [ForeignKey("courseTopic")]
        [InverseProperty("Courses")]
        public int courseTopicId { get; set; }
        public Topic courseTopic { get; set; } = null!;


        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();

        public ICollection<CourseInstrctors> courseInstrctors { get; set; } = new HashSet<CourseInstrctors>();

    }
}
