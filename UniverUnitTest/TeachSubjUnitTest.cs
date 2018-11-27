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
    public class TeachSubjUnitTest : AbstractTestClass<TeachSubj>
    {
        protected override void ChangeModel(TeachSubj model)
        {
            model.Subject = null;
            _context.SaveChanges();
        }

        protected override TeachSubj FindEqualModel(DbRepository<TeachSubj> r, TeachSubj model)
        {
            if (model.Id == 0)
            {
                return r.AllItems.ToList().FirstOrDefault(i =>
              i.Subject.Id == model.Subject.Id &&
              i.Teacher.Id == model.Teacher.Id
             );
            }
            else
            {
                return _context.TeachSubjs.Find(model.Id);
            }

        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.TeachSubjs;
            r = new TeachSubjsRepository(_context);
            model1 = new TeachSubj { Subject = _context.Subjects.FirstOrDefault(), Teacher = _context.Teachers.FirstOrDefault() };
            model2 = new TeachSubj { Subject = null, Teacher = null };
        }
    }
}
