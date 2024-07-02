using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Borrow
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Book Title")]
        public int? BookId { get; set; }
        public virtual Book? Book { get; set; }
        [DisplayName("Borrower Name")]
        public int? BorrowerId { get; set; }
        public virtual Borrower? Borrower { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date of borrowing")]
        public DateTime BorrowDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date of return")]
        public DateTime? ReturnDate { get; set; }
    }
}
