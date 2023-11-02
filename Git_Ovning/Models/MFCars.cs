using System.ComponentModel.DataAnnotations;

namespace Git_Ovning.Models
{
    public class MFCars
    {
        public int MFCarsId { get; set; }
        public string Brand { get; set;}
        public string Model { get; set;}
        [Range(1930, 3000)]
        public int YearModel { get; set; }
        public string PrimaryColor { get; set; } = "blue";
    }
}
