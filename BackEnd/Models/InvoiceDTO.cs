namespace BackEnd.Models
{
  public class InvoiceDTO
  {
    public uint InvoiceID { get; set; }

    public string Username { get; set; }

    public double BasePrice { get; set; }

    public double Labour { get; set; }

    public double Parts { get; set; }

    public double? RecoveryFee { get; set; }
  }
}