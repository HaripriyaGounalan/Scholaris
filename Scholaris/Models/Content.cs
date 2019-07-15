using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scholaris.Models
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }
        public String Title { get; set; }
        public String Contents { get; set; }
        public int CoursetId { get; set; }
        public byte[] Documents { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CreatedOn { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ModifiedOn { get; set; }
    }
}
