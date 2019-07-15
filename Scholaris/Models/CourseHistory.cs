using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scholaris.Models
{
    public class CourseHistory
    {
        [Key]
        public int CourseHistoryId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
    }
}
