using System.Collections.Generic;

namespace GreenWalk.Models
{
    public class Success
    {
        public int SuccessID { get; set; }
        public string Name { get; set; }
        public byte[] Logo { get; set; }

        public ICollection<User> Users { get; set; }

    }
}
