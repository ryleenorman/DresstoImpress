using System.ComponentModel.DataAnnotations;


namespace DresstoImpressAPI2.Entities

{
    public class Clothing
{
    [Key]
    public int ClothingID { get; set; }
    public string ClothingType { get; set; }
    public string ClothingSize { get; set; }

        }

    }