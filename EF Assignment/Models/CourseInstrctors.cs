using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Models
{
    [PrimaryKey(nameof(InsId),nameof(CourseId))]
    public class CourseInstrctors
    {
        [ForeignKey(nameof(Instructor))]
        public int InsId { get; set; }


        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }

        public int evaluate { get; set; }

        public Instructor Instructor { get; set; } = null!;
        public Course Course { get; set; } = null!;


    }
}
