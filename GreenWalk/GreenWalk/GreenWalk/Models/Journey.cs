using System;
using System.Collections.Generic;

namespace GreenWalk.Models
{
    public class Journey
    {
        public int JourneyID { get; set; }
        public User User { get; set; }
        public Byte[] Picture { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Position> Positions { get; set; }

    }
}
