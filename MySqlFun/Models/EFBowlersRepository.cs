using System;
using System.Linq;

namespace MySqlFun.Models
{
    public class EFBowlersRepository : IBowlersRepository
    {
        private BowlingLeagueDbContext _context { get; set; }
        
        public EFBowlersRepository (BowlingLeagueDbContext temp)
        {
            _context = temp;
        }

        public IQueryable<Bowler> Bowlers => _context.Bowlers;
    }
}
