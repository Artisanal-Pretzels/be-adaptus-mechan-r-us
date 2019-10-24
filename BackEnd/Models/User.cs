using System.Collections;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BackEnd.Models
{
    public class User
    {
        public uint UserID { get; set; }

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

        public ICollection<Invoice> Invoice { get; set; }

        public ICollection<Review> Review { get; set; }

        [DataType (DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [DataType (DataType.Date)]
        public DateTime LastUpdatedAt { get; set; }
    }
}