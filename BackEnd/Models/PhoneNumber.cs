using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class PhoneNumber
    {
        public uint PhoneNumberID { get; set; }

        [Required]
        [StringLength (15)]
        public string Number { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}