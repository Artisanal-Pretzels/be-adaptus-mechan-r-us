using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    public class Review
    {
        public uint ReviewID { get; set; }

        [Required]
        [Column(TypeName = "double(2, 1)")]
        [Range(0, 5)]
        public short Rating { get; set; }
    }
}