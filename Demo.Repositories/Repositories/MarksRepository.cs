using Demo.EntityConsole.Common;
using Entities.App;
using System.Data.Entity;

namespace Demo.Repositories
{
    public class MarksRepository : DbRepository<Mark>, IMarksRepository
    {
        public MarksRepository(DbContext context) : base(context)
        {
        }
    }
}
