﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string TopicName { get; set; }

        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
