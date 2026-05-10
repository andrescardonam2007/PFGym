using System;
using System.Collections.Generic;
using System.Text;
using Gym.Domain.Enums;
namespace Gym.Domain.Entities
{
    public class Trainer: AuditBase
    {
        public string name { get; set; } = string.Empty;

        public string email { get; set; } =string.Empty;

        public int tel { get; set; }

        public TrainerStatus status  { get; set; }

        //navegation Propiertie 
        public ICollection<GymClass> Class { get; set; } = new List<GymClass>();

    }
}
