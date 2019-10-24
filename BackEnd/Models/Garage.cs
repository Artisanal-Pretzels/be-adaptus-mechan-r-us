using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
  public class Garage
  {
    public uint GarageID { get; set; }

    [Required]
    [StringLength (200)]
    public string GarageName { get; set; }

    [Required]
    [StringLength (1000)]
    public string Description { get; set; }

    public string ImagePath { get; set; }

    [Required]
    [StringLength (256)]
    public string PaymentEmail { get; set; }

    [Required]
    [Column (TypeName = "double(5, 2)")]
    public double BasePrice { get; set; }

    public Address Address { get; set; }

    public ICollection<Invoice> Invoice { get; set; }

    public ICollection<Review> Review { get; set; }

    [DataType (DataType.Date)]
    public DateTime CreatedAt { get; set; }

    [DataType (DataType.Date)]
    public DateTime LastUpdatedAt { get; set; }
  }
}