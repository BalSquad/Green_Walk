using System;
using System.Collections.Generic;

namespace GreenWalkModel
{
    public class Position
    {
        public int PositionID  { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public DateTime Date { get; set; }

        public int JourneyID { get; set; }
        public Journey Journey { get; set; }

        public ICollection<Bin> Bins { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
