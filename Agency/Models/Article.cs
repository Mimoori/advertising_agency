using System.ComponentModel.DataAnnotations;

namespace Agency.Models
{
    public class Article
    {
        [Key]
        public int id_news { get; set; }
        /*[RegularExpression("^[a-zA-Zа-яА-ЯёЁs.,;:!?()\"'-]{1,256}$\r\n",
            ErrorMessage = "No")]*/
        [MaxLength(400)]
        [Required]
        public required string title { get; set; }

        /*[RegularExpression("^[a-zA-Zа-яА-ЯёЁ/s]{1,2000}$",
            ErrorMessage = "No")]*/
        [Required]
        [MaxLength(4000)]
        public required string descriptions { get; set; }

        public DateOnly datetime { get; set; }
    }
}
