using System.ComponentModel.DataAnnotations;
using System;


namespace BackEnd.Models
{
    public class PhoneNumber
    {
        public uint PhoneNumberID { get; set; }

        [Required]
        [StringLength (15)]
        public string Number { get; set; }

        public User User { get; set; }
        public uint UserID { get; set; }

        [DataType (DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [DataType (DataType.Date)]
        public DateTime LastUpdatedAt { get; set; }
    }
}