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
    public class SubjectUnitTest : AbstractTestClass<Subject>
    {
        protected override void ChangeModel(Subject model)
        {
            model.Name = "math";
            _context.SaveChanges();
        }

        protected override Subject FindEqualModel(DbRepository<Subject> r, Subject model)
        {
            //var b = model.Speciality == null;
            return r.AllItems.FirstOrDefault(i =>
              i.Name == model.Name 
              
             //&& (b || i.Speciality.Name == model.Speciality.Name)
             );
        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.Subjects;
            r = new SubjectsRepository(_context);
            model1 = new Subject { Name = "phys"};
            model2 = new Subject { Name = "hist"};
        }
    }
}
