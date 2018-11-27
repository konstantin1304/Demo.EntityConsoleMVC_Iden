using Demo.EntityConsole.Common;
using Entities.App;
using System.Data.Entity;

namespace Demo.Repositories
{
    public class PhonesRepository : DbRepository<Phone>, IPhonesRepository
    {
        public PhonesRepository(DbContext context) : base(context)
        {
        }
    }
}
