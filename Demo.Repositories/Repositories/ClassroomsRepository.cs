using Demo.EntityConsole.Common;
using Entities.App;
using System.Data.Entity;

namespace Demo.Repositories
{
    public class ClassroomsRepository : DbRepository<Classroom>, IClassroomsRepository
    {
        public ClassroomsRepository(DbContext context) : base(context)
        {
        }
    }
}
