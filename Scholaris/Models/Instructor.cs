﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scholaris.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }
    }
}
