using System.Collections.Generic;
using comp231_002__Team1_TeamUp_SportsBooking.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace comp231_002__Team1_TeamUp_SportsBooking.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet hiện có của nhóm
        public DbSet<Player> Players { get; set; } = default!;
        public DbSet<Team> Teams { get; set; } = default!;
        public DbSet<Game> Games { get; set; } = default!;

        // Quan trọng cho phần của m
        public DbSet<Court> Courts { get; set; } = default!;
        public DbSet<Booking> Bookings { get; set; } = default!;
    }
}
