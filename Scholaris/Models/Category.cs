using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scholaris.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public int? ParentId { get; set; }
        public String Name{ get; set; }
        public String Type { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CreatedOn { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ModifiedOn { get; set; }
    }
}
