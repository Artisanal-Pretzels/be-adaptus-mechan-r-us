using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    public class Garage
    {
        public int GarageID {get; set;}

        [Required]
        [StringLength (200)]
        public string GarageName { get; set; }

        [Required]
        [StringLength (500)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Required]
        [StringLength (256)]
        public string PaymentEmail { get; set; }

        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public double BasePrice { get; set; }

        public Address Address { get; set; }

        public ICollection<Invoice> Invoice { get; set; }

        public ICollection<Review> Review { get; set; }

    }
}