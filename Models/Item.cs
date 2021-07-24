using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Borrower { get; set; }

        [MaxLength(50)]
        public string Lender { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Item Name")]
        public string Name { get; set; }
    }
}
