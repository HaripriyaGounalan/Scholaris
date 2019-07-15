using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Scholaris.Models
{
    public enum CourseStatus
    {
        Started, InProgress, Completed
    }

    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public byte[] Image { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CreatedOn { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ModifiedOn { get; set; }

        public Status? CourseStatus { get; set; }

    }
}
