using System;
namespace GreenWalkModel
{
    public class Bin
    {
        public int BinID { get; set; }

        public int PositionID { get; set; }
        public Position Position { get; set; }

        public int UserID { get; set; }
        public User UserCreation { get; set; }
    }
}
