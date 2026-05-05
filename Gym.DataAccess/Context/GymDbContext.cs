using Microsoft.EntityFrameworkCore;
using Gym.Domain.Entities;

namespace Gym.DataAccess.Context;

public class GymDbContext : DbContext
{
    public GymDbContext(DbContextOptions<GymDbContext> options) : base(options)
    {
    }

    public DbSet<Member> Members => Set<Member>();
}