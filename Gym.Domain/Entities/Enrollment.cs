using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Domain.Entities
{
   public class Enrollment: AuditBase
    {
        public DateTime Stardate { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsActive { get; set; }

        //foreignkey 
        public int ClientId { get; set; }

        public int MembershipId { get; set; }
        //navigation propierties 
        public Member Members  { get; set; } = null!;
        public Membership Membership { get; set; } = null!;

    }
}
