using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeVending.Models
{
    [Table("Coffee")]
    public class Coffee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Country { get; set; }

        public string? Description { get; set; }

        public double? Price { get; set; }
        public string? Image { get; set; }
    }
}