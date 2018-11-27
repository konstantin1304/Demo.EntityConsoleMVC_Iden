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
    public class DepartmentUnitTest : AbstractTestClass<Department>
    {
        protected override void ChangeModel(Department model)
        {
            model.Name = "TTT";
            _context.SaveChanges();
        }

        protected override Department FindEqualModel(DbRepository<Department> r, Department model)
        {
            return r.AllItems.FirstOrDefault(i =>
              i.Name == model.Name
             );
        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.Departments;
            r = new DepartmentsRepository(_context);
            model1 = new Department { Name = "AAA"};
            model2 = new Department { Name = "BBB"};
        }
    }
}
