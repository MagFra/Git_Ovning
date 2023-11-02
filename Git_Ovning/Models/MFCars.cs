using System.ComponentModel.DataAnnotations;

namespace Git_Ovning.Models
{
    public class MFCars
    {
        [Key]
        public int MFCarsId { get; set; }
        [Required]
        public string Brand { get; set; } = string.Empty;
        [Required]
        public string Model { get; set; } = string.Empty;
        [Range(1930, 3000)]
        public int YearModel { get; set; }       
        public string? PrimaryColor { get; set; }
    }
}
