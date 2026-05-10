using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Domain.Entities
{
    public class Member : AuditBase
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string email {get; set; } = string.Empty;
        public int? tel { get; set; }
        public DateTime BirthDate { get; set; }

        //navigation propierty
        public ICollection<GymClass> Class { get; set; } = new List<GymClass>();

        public ICollection<Membership> Memberships { get; set; }= new List<Membership>();


    }
}
