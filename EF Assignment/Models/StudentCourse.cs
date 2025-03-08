using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Models
{
    [PrimaryKey(nameof(StdId),nameof(CrsId))]
    public class StudentCourse
    {
        [ForeignKey("student")]
        public int StdId { get; set; }
        [ForeignKey(nameof(course))]
        public int CrsId { get; set; }
        public int Grade { get; set; }


        //Navigation Property[one]
        public Student student { get; set; } = null!;

        public Course course { get; set; } = null!;
    }
}
