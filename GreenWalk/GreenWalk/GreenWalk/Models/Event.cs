using System;
namespace GreenWalk.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string Name { get; set; }
        public string Descritpion { get; set; }
        public DateTime Date { get; set; }

        public int UserID { get; set; }
        public User UserPlanner { get; set; }

        public int PositionID { get; set; }
        public Position PositionStart { get; set; }
    }
}
