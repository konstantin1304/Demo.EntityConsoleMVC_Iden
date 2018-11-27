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
    public class TimetableUnitTest : AbstractTestClass<Timetable>
    {
        protected override void ChangeModel(Timetable model)
        {
            model.Classroom = null;
            _context.SaveChanges();
        }

        protected override Timetable FindEqualModel(DbRepository<Timetable> r, Timetable model)
        {
            if (model.Id == 0)
            {
                return r.AllItems.ToList().FirstOrDefault(i =>
              i.Classroom.Id == model.Classroom.Id &&
              i.TeachSubj.Id == model.TeachSubj.Id &&
              i.PairTimetable.Id == model.PairTimetable.Id
             );
            }
            else
            {
                return _context.Timetables.Find(model.Id);
            }

        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.Timetables;
            r = new TimetablesRepository(_context);
            model1 = new Timetable { Classroom = _context.Classrooms.FirstOrDefault(), TeachSubj = _context.TeachSubjs.FirstOrDefault(), PairTimetable = _context.PairTimetables.FirstOrDefault() };
            model2 = new Timetable { Classroom = null, TeachSubj = null, PairTimetable = null };
        }
    }
}
