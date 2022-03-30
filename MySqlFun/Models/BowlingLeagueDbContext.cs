using System;
using Microsoft.EntityFrameworkCore;

namespace MySqlFun.Models
{
    public class BowlingLeagueDbContext :DbContext
    {
        public BowlingLeagueDbContext(DbContextOptions<BowlingLeagueDbContext> options) : base(options)
        {

        }

        public DbSet<Bowler> Bowlers { get; set; }


    }
}
