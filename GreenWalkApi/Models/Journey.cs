using System;
using System.Collections.Generic;

namespace GreenWalkApi.Models
{
    public class Journey
    {
        public int JourneyID { get; set; }
        public Byte[] Picture { get; set; }
        public DateTime Date { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
        public ICollection<Position> Positions { get; set; }

    }
}
