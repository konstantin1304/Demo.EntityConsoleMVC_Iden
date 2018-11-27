using Demo.EntityConsole.Common;
using Demo.Repositories;
using Entities.App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniverUnitTest
{
    [TestClass]
    public class SpecialityUnitTest : AbstractTestClass<Speciality>
    {
        protected override void ChangeModel(Speciality model)
        {
            model.Name = "PM";
            _context.SaveChanges();
        }

        protected override Speciality FindEqualModel(DbRepository<Speciality> r, Speciality model)
        {
            var speciality = r.AllItems.FirstOrDefault(i =>
              i.Name == model.Name
             );
            if ((speciality?.Department?.Id == model.Department?.Id))
            {
                return speciality;
            }
            return null;
        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.Specialities;
            r = new SpecialitiesRepository(_context);
            model1 = new Speciality { Name = "Eco", Department = _context.Departments.FirstOrDefault()};
            model2 = new Speciality { Name = "Femida", Department = _context.Departments.FirstOrDefault()};
        }
    }
}
