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
    public class MarkUnitTest : AbstractTestClass<Mark>
    {
        protected override void ChangeModel(Mark model)
        {
            model.MarkStud = 3;
            _context.SaveChanges();
        }

        protected override Mark FindEqualModel(DbRepository<Mark> r, Mark model)
        {
            var mark = r.AllItems.FirstOrDefault(i =>
              i.MarkStud == model.MarkStud
             );
            if ((mark?.TeachSubj?.Id == model.TeachSubj?.Id) && (mark?.Student?.Id == model.Student?.Id))
            {
                return mark;
            }
           return null;
        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.Marks;
            r = new MarksRepository(_context);
            model1 = new Mark { MarkStud = 1, Student = _context.Students.FirstOrDefault(), TeachSubj = _context.TeachSubjs.FirstOrDefault() };
            model2 = new Mark { MarkStud = 2, Student = _context.Students.FirstOrDefault(), TeachSubj = _context.TeachSubjs.FirstOrDefault() };
        }
    }
}
