using System;
using Microsoft.EntityFrameworkCore;

namespace GreenWalkApi.Models
{
    public interface IGreenWalkContext
    {
             DbSet<User> Users { get; set; }
             DbSet<Journey> Journeys { get; set; }
             DbSet<Position> Positions { get; set; }
             DbSet<Bin> Bins { get; set; }
             DbSet<Event> Events { get; set; }
             DbSet<Success> Successes { get; set; }
    }
}
