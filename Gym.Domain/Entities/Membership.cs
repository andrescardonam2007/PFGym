using Gym.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Domain.Entities
{
    public class Membership : AuditBase
    {
        public string Description { get; set; } = string.Empty;
        public TypeOfMembership TypeOfMembership { get; set; }
        public decimal Price { get; set; }
        public int DurationInDays { get; set; }

        //navegation propiertie 
        public ICollection<Member> Members { get; set; } = new List<Member>();
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
