using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MagicVilla_VillaAPI.Dto
{
    public class VillaDto
    {

        
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int rate { get; set; } = 0;

        public int Sqft { get; set; }

        public int Occupancy { get; set; } = 0;
        public int OccupancyMax { get; set; } = 0;
        [NotNull]
        public string imgUrl { get; set; }
        public int OccupancyMin { get; set; } = 0;
    }
}
