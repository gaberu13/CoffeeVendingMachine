using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeVending.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("CoffeeId")]
        public int CoffeeId { get; set; }
        public Coffee? Coffee { get; set; }
        public string? Suger { get; set; }

        public bool? Milk { get; set; }
        public bool? Caramelle { get; set; }
        public bool? Creamer { get; set; }
        public bool? Decofe { get; set; }

    }
}