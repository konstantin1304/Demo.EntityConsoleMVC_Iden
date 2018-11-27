using Demo.EntityConsole.Common;
using Entities.App;
using System.Data.Entity;

namespace Demo.Repositories
{
    public class PairTimetablesRepository : DbRepository<PairTimetable>, IPairTimetablesRepository
    {
        public PairTimetablesRepository(DbContext context) : base(context)
        {
        }
    }
}
