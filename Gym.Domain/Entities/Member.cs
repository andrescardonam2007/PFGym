using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Domain.Entities
{
    public class Member : AuditBase
    {
        public string Name { get; set; } = string.Empty;
    }
}
