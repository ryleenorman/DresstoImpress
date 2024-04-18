using System.ComponentModel.DataAnnotations;

namespace DresstoImpressAPI2.Entities
{
    public class USERS
    {
        
        [Key]
        public int UserID { get; set; }
        public string UserOccupation { get; set; }
    }
}
    