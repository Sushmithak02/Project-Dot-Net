using System.ComponentModel.DataAnnotations;

namespace Book_PAL.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50,ErrorMessage ="Not more than 50")]
        public string BookName { get; set; }

        [Required]
        [StringLength(35,ErrorMessage ="Should be less than 20")]
        public string Genre { get; set; }

        public bool AvailabilityStatus { get; set; }
    }
}
