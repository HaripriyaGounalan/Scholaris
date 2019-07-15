using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scholaris.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

    }
}
