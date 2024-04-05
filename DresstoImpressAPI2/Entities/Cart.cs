using System.ComponentModel.DataAnnotations;


namespace DresstoImpressAPI2.Entities

{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }
        public int UserID { get; set; }

    }

}