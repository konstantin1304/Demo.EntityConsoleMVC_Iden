using Demo.EntityConsole.Common;
using Entities.App;
using System.Data.Entity;

namespace Demo.Repositories
{
    public class GroupsRepository : DbRepository<Group>, IGroupsRepository
    {
        public GroupsRepository(DbContext context) : base(context)
        {
        }
    }
}
