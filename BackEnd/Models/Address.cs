using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class Address
    {
        public int AddressID { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        [StringLength(200)]
        public string LineOne { get; set; }

        [Required]
        [StringLength(200)]
        public string LineTwo { get; set; }

        [Required]
        [StringLength(200)]
        public string County { get; set; }

        [Required]
        [StringLength(10)]
        public string PostCode { get; set; }

        public Garage Garage { get; set; }

        public int GarageID { get; set; }
    }
}