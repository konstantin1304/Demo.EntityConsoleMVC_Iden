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
    public class ClassroomUnitTest : AbstractTestClass<Classroom>
    {
        protected override void ChangeModel(Classroom model)
        {
            model.Floor = 10;
            _context.SaveChanges();
        }

        protected override Classroom FindEqualModel(DbRepository<Classroom> r, Classroom model)
        {
            return r.AllItems.FirstOrDefault(i =>
              i.Capacity == model.Capacity &&
              i.ClassroomNumber == model.ClassroomNumber &&
              i.Floor == model.Floor
             );
        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.Classrooms;
            r = new ClassroomsRepository(_context);
            model1 = new Classroom { Capacity = 30, ClassroomNumber = 201, Floor = 2 };
            model2 = new Classroom { Capacity = 40, ClassroomNumber = 202, Floor = 2 };
        }
    }
}
