using System;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
  public class Invoice
  {
    public uint InvoiceID { get; set; }

    public User User { get; set; }

    public uint UserID { get; set; }

    public Garage Garage { get; set; }

    public uint GarageID { get; set; }

    [DataType (DataType.Date)]
    public DateTime CreatedAt { get; set; }

    [DataType (DataType.Date)]
    public DateTime LastUpdatedAt { get; set; }
  }
}