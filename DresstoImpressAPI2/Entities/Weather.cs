using System.ComponentModel.DataAnnotations;

namespace DresstoImpressAPI2.Entities
{
    public class Weather
    {
        [Key]
        public int WeatherID { get; set; }

        public string WeatherType { get; set; }

        public string Temperature { get; set; }

        public string Precipitation { get; set; }
    }
}