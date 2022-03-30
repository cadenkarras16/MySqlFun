using System;
using System.Linq;

namespace MySqlFun.Models
{
    public interface IBowlersRepository
    {
        IQueryable<Bowler> Bowlers { get; }
    }
}
