using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
  public class Review
  {
    public uint ReviewID { get; set; }

    [Required]
    [Column (TypeName = "double(2, 1)")]
    [Range (0, 5)]
    public short Rating { get; set; }

    [StringLength (500)]
    public string Body { get; set; }

    public Garage Garage { get; set; }

    public uint GarageID { get; set; }

    public User User { get; set; }

    public uint UserID { get; set; }

    [DataType (DataType.Date)]
    public DateTime CreatedAt { get; set; }

    [DataType (DataType.Date)]
    public DateTime LastUpdatedAt { get; set; }
  }
}