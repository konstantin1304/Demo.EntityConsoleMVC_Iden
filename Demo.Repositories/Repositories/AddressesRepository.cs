using Demo.EntityConsole.Common;
using Entities.App;
using System.Data.Entity;

namespace Demo.Repositories
{
    public class AddressesRepository : DbRepository<Address>, IAddressesRepository
    {
        public AddressesRepository(DbContext context) : base(context)
        {
        }
    }
   
}
