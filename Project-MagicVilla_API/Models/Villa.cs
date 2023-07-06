using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_MagicVilla_API.Models
{
    public class Villa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Details { get; set; }

        [Required]
        public double Rate { get; set; }
        public int Sqrft { get; set; }
        public int Occupancy { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public DateTime UpdatedDate { get; set; }= DateTime.Now;
    }
}
