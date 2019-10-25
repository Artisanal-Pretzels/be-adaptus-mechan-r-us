using System.Collections.Generic;

namespace BackEnd.Models
{
    public class GarageDistanceDTO
    {
        public uint GarageID { get; set; }

        public string GarageName { get; set; }

        public double Ratings { get; set; }

        public double BasePrice { get; set; }

        public DistanceDTO Distance { get; set;}
    }
}