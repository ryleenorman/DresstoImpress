using System.ComponentModel.DataAnnotations;

namespace DresstoImpressAPI2.Entities
{
    public class GetTemperature
    {
        [Key]
        public int WeatherID { get; set; }
        public string Temperature { get; set; }
    }
}
