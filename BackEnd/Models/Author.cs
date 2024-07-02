using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date of birth")]
        public DateTime BirthDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date of death")]
        public DateTime? DeathDate { get; set; }
    }
}
