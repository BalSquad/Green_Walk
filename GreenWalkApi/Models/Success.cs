using System;
using System.Collections.Generic;

namespace GreenWalkApi.Models
{
    public class Success
    {
        public int SuccessID { get; set; }
        public string Name { get; set; }
        public Byte[] Logo { get; set; }
        public ICollection<User> User { get; set; }

    }
}
