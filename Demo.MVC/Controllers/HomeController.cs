using Demo.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.MVC.Controllers
{
    public class HomeController : Controller
    {
        MyAppDbContext _context = new MyAppDbContext("MyAppConnStr");
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Departments()
        {
            return View(_context.Departments.ToList());
        }
        public ActionResult Students()
        {
            return View(_context.Students.ToList());
        }
        public ActionResult Addresses()
        {
            return View(_context.Addresses.ToList());
        }
        public ActionResult Classrooms()
        {
            return View(_context.Classrooms.ToList());
        }
        public ActionResult GroupTimetables()
        {
            return View(_context.GroupTimetables.ToList());
        }
        public ActionResult Marks()
        {
            return View(_context.Marks.ToList());
        }
        public ActionResult Groups()
        {
            return View(_context.Groups.ToList());
        }
        public ActionResult PairTimetables()
        {
            return View(_context.PairTimetables.ToList());
        }
        public ActionResult Phones()
        {
            return View(_context.Phones.ToList());
        }
        public ActionResult Specialities()
        {
            return View(_context.Specialities.ToList());
        }
        public ActionResult Subjects()
        {
            return View(_context.Subjects.ToList());
        }
        public ActionResult Teachers()
        {
            return View(_context.Teachers.ToList());
        }
        public ActionResult Timetables()
        {
            return View(_context.Timetables.ToList());
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}