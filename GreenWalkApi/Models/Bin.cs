using System;
namespace GreenWalkApi.Models
{
    public class Bin
    {
        public int BinID { get; set; }
        public Position Position { get; set; }
        public User UserCreation { get; set; }
    }
}
