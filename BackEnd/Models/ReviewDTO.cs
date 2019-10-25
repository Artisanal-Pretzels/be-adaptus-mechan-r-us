namespace BackEnd.Models
{
  public class ReviewDTO
  {
    public uint ReviewID { get; set; }

    public short Rating { get; set; }

    public string Body { get; set; }

    public string Username { get; set; }

  }
}