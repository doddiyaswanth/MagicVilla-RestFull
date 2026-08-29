using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_VillaAPI.Models
{
    public class Villa
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int rate { get; set; } = 0;

        public int Sqft { get; set; }


        public string imgUrl { get; set; }
        public int Occupancy { get; set; } = 0;
        public int OccupancyMax { get; set; } = 0;

        public int OccupancyMin { get; set; } = 0;      

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set;} = DateTime.Now;    



    }
}