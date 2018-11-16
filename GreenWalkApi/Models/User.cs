using System;
using System.Collections.Generic;

namespace GreenWalkApi.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailAdress { get; set; }
        public string Password { get; set; }
        public Byte[] Avatar { get; set; }
        public string Pseudo { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Journey> Journeys { get; set; }
        public ICollection<Bin> Bins { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Success> Success { get; set; }
    }
}
