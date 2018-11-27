using Demo.EntityConsole.Common;
using Entities.App;
using System.Data.Entity;

namespace Demo.Repositories
{
    public class TeachSubjsRepository : DbRepository<TeachSubj>, ITeachSubjsRepository
    {
        public TeachSubjsRepository(DbContext context) : base(context)
        {
        }
    }
}
