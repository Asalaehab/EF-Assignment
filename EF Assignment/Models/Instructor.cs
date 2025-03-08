using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Models
{
    public class Instructor
    {
        [Key]
        public int Ins_Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Bouns { get; set; }


      
        [Column("Salary",TypeName ="decimal(18,2)")]
        public decimal Salary { get; set; }


        public string  Ins_Address { get; set; }

        public int HourRate { get; set; }


        public int InstructorDepartmentId { get; set; }
        public Department InstructorDepartment { get; set; } = null!;

        public ICollection<CourseInstrctors> courseInstrctors { get; set; } = new HashSet<CourseInstrctors>();

    }
}
