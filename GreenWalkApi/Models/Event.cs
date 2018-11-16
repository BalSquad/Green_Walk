using System;
namespace GreenWalkApi.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public User UserPlanner { get; set; }
        public Position PositionStart { get; set; }
        public string Name { get; set; }
        public string Descritpion { get; set; }
        public DateTime Date { get; set; }
    }
}
