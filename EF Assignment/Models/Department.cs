using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Models
{
    public class Department
    {
        [Key]
        public int dept_Id { get; set; }


        [Required]
        [Column("Dept_Name",TypeName ="varchar(100)")]
        public string DepartmentName { get; set; }

        [Required]
        public DateTime HiringDate { get; set; }

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();



        //Navigation Property
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }
}
