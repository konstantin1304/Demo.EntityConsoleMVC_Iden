using Demo.EntityConsole.Common;
using Entities.App;
using System.Data.Entity;

namespace Demo.Repositories
{
    public class SpecialitiesRepository : DbRepository<Speciality>, ISpecialitiesRepository
    {
        public SpecialitiesRepository(DbContext context) : base(context)
        {
        }
    }
}
