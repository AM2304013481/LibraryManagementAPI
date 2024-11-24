using System.ComponentModel.DataAnnotations;

namespace LibraryManagementAPI.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Required]
        [MaxLength(100)]
        public string BookName { get; set; }

        [Required]
        [MaxLength(100)]
        public string BookAuthor { get; set; }


    }
}
