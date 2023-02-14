

namespace CoffeeVending.Models.DTO
{
    public class OrderDTO
    {
        public int CoffeeId { get; set; }
        public Coffee? Coffee { get; set; }
        public string? Suger { get; set; }

        public bool? Milk { get; set; }
        public bool? Caramelle { get; set; }
        public bool? Creamer { get; set; }
        public bool? Decofe { get; set; }

    }
}