using System.Collections.Generic;

namespace BackEnd.Models
{
  public class GarageDTO
  {
    public uint GarageID { get; set; }

    public string GarageName { get; set; }

    public string Description { get; set; }

    public string ImagePath { get; set; }

    public double BasePrice { get; set; }

    public string PhoneNumber { get; set; }

    public AddressDTO Address { get; set; }

    public ICollection<InvoiceDTO> Invoices { get; set; }

    public ICollection<ReviewDTO> Reviews { get; set; }
  }
}