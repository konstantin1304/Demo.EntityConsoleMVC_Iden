using System;
using System.Collections.Generic;
using System.Linq;
using Demo.AppContext;
using Demo.EntityConsole.Common;
using Demo.Repositories;
using Entities.App;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniverUnitTest
{
   
    [TestClass]
    public class AddressUnitTest:AbstractTestClass<Address>
    {

        protected override void ChangeModel(Address model)
        {
            model.ZipCode = 49011;
            _context.SaveChanges();
        }

        protected override Address FindEqualModel(DbRepository<Address> r, Address model)
        {
           return r.AllItems.FirstOrDefault(i =>
             i.ZipCode == model.ZipCode &&
             i.Street == model.Street &&
             i.House == model.House &&
             i.Building == model.Building &&
             i.City == model.City &&
             i.Flat == model.Flat &&
             i.Region == model.Region
            );
        }
        [TestInitialize]
        public override void InitParams()
        {
            r = new AddressesRepository(_context);
            dbSet = _context.Addresses;
            model1 = new Address { ZipCode = 49000, City = "Dnepr", Street = "Lomanaya", StreetKind = "strt", House = "1", Region = "Dneprovskaya" };
            model2 = new Address { ZipCode = 49005, City = "Dnepr", Street = "Artyoma", StreetKind = "strt", House = "3", Region = "Dneprovskaya" };
        }

    }
}
