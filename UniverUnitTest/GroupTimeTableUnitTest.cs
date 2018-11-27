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
    public class GroupTimetableUnitTest:AbstractTestClass<GroupTimetable>
    {
        protected override void ChangeModel(GroupTimetable model)
        {
            model.Group = null;
            _context.SaveChanges();
        }

        protected override GroupTimetable FindEqualModel(DbRepository<GroupTimetable> r, GroupTimetable model)
        {
            if (model.Id == 0)
            {
                return r.AllItems.ToList().FirstOrDefault(i =>
              i.Group.Id == model.Group.Id &&
              i.Timetable.Id == model.Timetable.Id
             );
            }
            else
            {
                return _context.GroupTimetables.Find(model.Id);
            }
            
        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.GroupTimetables;
            r = new GroupTimetablesRepository(_context);
            model1 = new GroupTimetable { Group=_context.Groups.FirstOrDefault(), Timetable=_context.Timetables.FirstOrDefault() };
            model2 = new GroupTimetable { Group = null, Timetable = null };
        }
    }
}
