using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryMasterNew.Models
{
    public class Aisle
    {
        [Key]
        public int AisleId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int AisleCap { get; set; }

        // Properties from the Bikes model
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public bool Available { get; set; }

        public ICollection<Rentals> Rentals { get; set; }
    }

    public class AisleDto
    {
        public int AisleId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int AisleCap { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public bool Available { get; set; }
        public ICollection<Rentals> Rentals { get; set; }
    }

    public class AisleViewModel
    {
        public int AisleId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int AisleCap { get; set; } = 0;
        public IEnumerable<ItemDto> Item { get; set; }
        public IEnumerable<AisleDto> AisleList { get; internal set; }
    }
}
