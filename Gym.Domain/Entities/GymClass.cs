using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Domain.Entities
{
    public class GymClass: AuditBase
    {
        public string Name { get; set; } = string.Empty;

        public DateTime Schedule { get; set; }


        //navegation Propierties


        public ICollection<Trainer> Trainer { get; set; } = new List<Trainer>();
        public ICollection<Member> Members { get; set; } = new List<Member>();




    }
}
