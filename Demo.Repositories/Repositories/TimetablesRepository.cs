using Demo.EntityConsole.Common;
using Entities.App;
using System.Data.Entity;

namespace Demo.Repositories
{
    public class TimetablesRepository : DbRepository<Timetable>, ITimetablesRepository
    {
        public TimetablesRepository(DbContext context) : base(context)
        {
        }
    }
}
