using System;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
  public class Address
  {
    public uint AddressID { get; set; }

    [Required]
    public double Latitude { get; set; }

    [Required]
    public double Longitude { get; set; }

    [Required]
    [StringLength (200)]
    public string LineOne { get; set; }

    [Required]
    [StringLength (200)]
    public string LineTwo { get; set; }

    [Required]
    [StringLength (200)]
    public string County { get; set; }

    [Required]
    [StringLength (10)]
    public string PostCode { get; set; }

    public Garage Garage { get; set; }

    public uint GarageID { get; set; }

    [DataType (DataType.Date)]
    public DateTime CreatedAt { get; set; }

    [DataType (DataType.Date)]
    public DateTime LastUpdatedAt { get; set; }
  }
}