using Demo.EntityConsole.Common;
using Entities.App;
using System.Data.Entity;

namespace Demo.Repositories
{
    public class GroupTimetablesRepository : DbRepository<GroupTimetable>, IGroupTimetablesRepository
    {
        public GroupTimetablesRepository(DbContext context) : base(context)
        {
        }
    }
}
