using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        [StringLength (200)]
        public string Username { get; set; }

        [Required]
        [StringLength (200)]
        public string Password { get; set; }

        [Required]
        [StringLength (200)]
        public string Name { get; set; }

        [Required]
        [StringLength (256)]
        public string Email { get; set; }

        [Required]
        public PhoneNumber PhoneNumber { get; set; }

        [Required]
        [StringLength (200)]
        public string PaymentEmail { get; set; }

        [DataType (DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [DataType (DataType.Date)]
        public DateTime LastUpdatedAt { get; set; }
    }
}