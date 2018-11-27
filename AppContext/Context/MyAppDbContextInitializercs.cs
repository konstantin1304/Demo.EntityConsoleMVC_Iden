using Entities.App;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.AppContext
{

    //DropCreateDatabaseAlways<MyAppDbContext>
    //DropCreateDatabaseIfModelChanges<MyAppDbContext>
    //CreateDatabaseIfNotExists<MyAppDbContext>
    public class MyAppDbContextInitializer : CreateDatabaseIfNotExists<MyAppDbContext>
    {
        protected override void Seed(MyAppDbContext context)
        {
            context.Departments.Add(new Department { Name = "PROGRAMMING" });
            context.Departments.Add(new Department { Name = "TESTING" });
            context.SaveChanges();

            context.Subjects.Add(new Subject { Name = "Java Basic" });
            context.Subjects.Add(new Subject { Name = "OOP Basic" });
            context.Subjects.Add(new Subject { Name = "Autotestig" });
            context.Subjects.Add(new Subject { Name = "Unint testing" });
            context.Subjects.Add(new Subject { Name = "TDD Basic" });
            context.SaveChanges();

            context.Teachers.Add(new Teacher { FirstName = "Vasily", MiddleName = "Pupkin", LastName = "Ivanovich", Department = context.Departments.FirstOrDefault(a => a.Id == 1) });
            context.Teachers.Add(new Teacher { FirstName = "Ivan", MiddleName = "Kosenko", LastName = "Petrovich", Department = context.Departments.FirstOrDefault(a => a.Id == 2) });
            context.SaveChanges();

            context.TeachSubjs.Add(new TeachSubj
            {
                Teacher = context.Teachers.FirstOrDefault(a => a.Id == 1),
                Subject = context.Subjects.FirstOrDefault(b => b.Id == 1),
            });
            context.TeachSubjs.Add(new TeachSubj
            {
                Teacher = context.Teachers.FirstOrDefault(a => a.Id == 1),
                Subject = context.Subjects.FirstOrDefault(b => b.Id == 2)
            });
            context.TeachSubjs.Add(new TeachSubj
            {
                Teacher = context.Teachers.FirstOrDefault(a => a.Id == 1),
                Subject = context.Subjects.FirstOrDefault(b => b.Id == 3)
            });
            context.TeachSubjs.Add(new TeachSubj
            {
                Teacher = context.Teachers.FirstOrDefault(a => a.Id == 2),
                Subject = context.Subjects.FirstOrDefault(b => b.Id == 4)
            });
            context.TeachSubjs.Add(new TeachSubj
            {
                Teacher = context.Teachers.FirstOrDefault(a => a.Id == 2),
                Subject = context.Subjects.FirstOrDefault(b => b.Id == 5)
            });
            context.SaveChanges();

            context.Specialities.Add(new Speciality { Name = "Software Developer" });
            context.Specialities.Add(new Speciality { Name = "TDD" });
            context.SaveChanges();

            context.Groups.Add(new Group { Name = "ПМ-07-1", Speciality = context.Specialities.FirstOrDefault(s => s.Id == 1) });
            context.Groups.Add(new Group { Name = "ВЗ-07-1", Speciality = context.Specialities.FirstOrDefault(s => s.Id == 2) });
            context.SaveChanges();

            context.Addresses.Add(new Address { City = "Dnipro", Street = "Artema", ZipCode = 49000, House = "1a" });
            context.SaveChanges();

            context.Students.Add(new Student { FirstName = "Vasya", MiddleName = "Kovtun", LastName = "Petrovich", LogbookNumber = 111, Email = "vasya123@gmail.com", Birthday = new DateTime(1995, 4, 5), Address = context.Addresses.FirstOrDefault(s => s.Id == 1), Group = context.Groups.FirstOrDefault(s => s.Id == 1) });
            context.Students.Add(new Student { FirstName = "Petya", MiddleName = "Zovtunov", LastName = "Vedorovich", LogbookNumber = 112, Email = "petya123@gmail.com", Birthday = new DateTime(1996, 5, 6), Address = context.Addresses.FirstOrDefault(s => s.Id == 1), Group = context.Groups.FirstOrDefault(s => s.Id == 1) });
            context.Students.Add(new Student { FirstName = "Senya", MiddleName = "Gavtun", LastName = "Andreevich", LogbookNumber = 121, Email = "senya123@gmail.com", Birthday = new DateTime(1997, 6, 7), Address = context.Addresses.FirstOrDefault(s => s.Id == 1), Group = context.Groups.FirstOrDefault(s => s.Id == 2) });
            context.Students.Add(new Student { FirstName = "Fedya", MiddleName = "Minaev", LastName = "Nikolaevich", LogbookNumber = 122, Email = "fedya123@gmail.com", Birthday = new DateTime(1998, 7, 8), Address = context.Addresses.FirstOrDefault(s => s.Id == 1), Group = context.Groups.FirstOrDefault(s => s.Id == 2) });
            context.SaveChanges();

            context.Phones.Add(new Phone { PhoneNumber = "0933530494", Student = context.Students.FirstOrDefault(s => s.Id == 1) });
            context.Phones.Add(new Phone { PhoneNumber = "0963530495", Student = context.Students.FirstOrDefault(s => s.Id == 2) });
            context.Phones.Add(new Phone { PhoneNumber = "0953530496", Student = context.Students.FirstOrDefault(s => s.Id == 3) });
            context.Phones.Add(new Phone { PhoneNumber = "0993530497", Student = context.Students.FirstOrDefault(s => s.Id == 4) });
            context.SaveChanges();

            context.Marks.Add(new Mark { Student = context.Students.FirstOrDefault(s => s.Id == 1), TeachSubj = context.TeachSubjs.FirstOrDefault(t => t.Id == 1), MarkStud = 12 });
            context.Marks.Add(new Mark { Student = context.Students.FirstOrDefault(s => s.Id == 2), TeachSubj = context.TeachSubjs.FirstOrDefault(t => t.Id == 1), MarkStud = 10 });
            context.Marks.Add(new Mark { Student = context.Students.FirstOrDefault(s => s.Id == 3), TeachSubj = context.TeachSubjs.FirstOrDefault(t => t.Id == 3), MarkStud = 8 });
            context.Marks.Add(new Mark { Student = context.Students.FirstOrDefault(s => s.Id == 4), TeachSubj = context.TeachSubjs.FirstOrDefault(t => t.Id == 3), MarkStud = 6 });

            context.Marks.Add(new Mark { Student = context.Students.FirstOrDefault(s => s.Id == 1), TeachSubj = context.TeachSubjs.FirstOrDefault(t => t.Id == 2), MarkStud = 12 });
            context.Marks.Add(new Mark { Student = context.Students.FirstOrDefault(s => s.Id == 2), TeachSubj = context.TeachSubjs.FirstOrDefault(t => t.Id == 2), MarkStud = 10 });
            context.Marks.Add(new Mark { Student = context.Students.FirstOrDefault(s => s.Id == 3), TeachSubj = context.TeachSubjs.FirstOrDefault(t => t.Id == 4), MarkStud = 8 });
            context.Marks.Add(new Mark { Student = context.Students.FirstOrDefault(s => s.Id == 4), TeachSubj = context.TeachSubjs.FirstOrDefault(t => t.Id == 4), MarkStud = 6 });

            context.Marks.Add(new Mark { Student = context.Students.FirstOrDefault(s => s.Id == 1), TeachSubj = context.TeachSubjs.FirstOrDefault(t => t.Id == 5), MarkStud = 12 });
            context.Marks.Add(new Mark { Student = context.Students.FirstOrDefault(s => s.Id == 2), TeachSubj = context.TeachSubjs.FirstOrDefault(t => t.Id == 5), MarkStud = 10 });
            context.Marks.Add(new Mark { Student = context.Students.FirstOrDefault(s => s.Id == 3), TeachSubj = context.TeachSubjs.FirstOrDefault(t => t.Id == 5), MarkStud = 8 });
            context.Marks.Add(new Mark { Student = context.Students.FirstOrDefault(s => s.Id == 4), TeachSubj = context.TeachSubjs.FirstOrDefault(t => t.Id == 5), MarkStud = 6 });
            context.SaveChanges();

            context.Classrooms.Add(new Classroom { Capacity = 50, Floor = 1, ClassroomNumber = 101 });
            context.Classrooms.Add(new Classroom { Capacity = 20, Floor = 1, ClassroomNumber = 102 });
            context.Classrooms.Add(new Classroom { Capacity = 20, Floor = 1, ClassroomNumber = 103 });
            context.Classrooms.Add(new Classroom { Capacity = 20, Floor = 1, ClassroomNumber = 104 });
            context.SaveChanges();

            context.PairTimetables.Add(new PairTimetable { BeginPair = new DateTime(1970, 1, 1, 08, 00, 0), EndPair = new DateTime(1970, 1, 1, 09, 20, 0), PairNumber = 1, DayOfTheWeek = 1 });
            context.PairTimetables.Add(new PairTimetable { BeginPair = new DateTime(1970, 1, 1, 09, 30, 0), EndPair = new DateTime(1970, 1, 1, 10, 50, 0), PairNumber = 2, DayOfTheWeek = 1 });
            context.PairTimetables.Add(new PairTimetable { BeginPair = new DateTime(1970, 1, 1, 11, 10, 0), EndPair = new DateTime(1970, 1, 1, 12, 30, 0), PairNumber = 3, DayOfTheWeek = 1 });
            context.PairTimetables.Add(new PairTimetable { BeginPair = new DateTime(1970, 1, 1, 12, 40, 0), EndPair = new DateTime(1970, 1, 1, 14, 00, 0), PairNumber = 4, DayOfTheWeek = 1 });
                                                                                                                                   
            context.PairTimetables.Add(new PairTimetable { BeginPair = new DateTime(1970, 1, 1, 08, 00, 0), EndPair = new DateTime(1970, 1, 1, 09, 20, 0), PairNumber = 1, DayOfTheWeek = 3 });
            context.PairTimetables.Add(new PairTimetable { BeginPair = new DateTime(1970, 1, 1, 09, 30, 0), EndPair = new DateTime(1970, 1, 1, 10, 50, 0), PairNumber = 2, DayOfTheWeek = 3 });
            context.PairTimetables.Add(new PairTimetable { BeginPair = new DateTime(1970, 1, 1, 11, 10, 0), EndPair = new DateTime(1970, 1, 1, 12, 30, 0), PairNumber = 3, DayOfTheWeek = 3 });
            context.PairTimetables.Add(new PairTimetable { BeginPair = new DateTime(1970, 1, 1, 12, 40, 0), EndPair = new DateTime(1970, 1, 1, 14, 00, 0), PairNumber = 4, DayOfTheWeek = 3 });
            context.SaveChanges();

            context.Timetables.Add(new Timetable { Classroom = context.Classrooms.FirstOrDefault(a => a.Id == 1), TeachSubj = context.TeachSubjs.FirstOrDefault(a => a.Id == 5), PairTimetable = context.PairTimetables.FirstOrDefault(a => a.Id == 1) });
            context.Timetables.Add(new Timetable { Classroom = context.Classrooms.FirstOrDefault(a => a.Id == 2), TeachSubj = context.TeachSubjs.FirstOrDefault(a => a.Id == 1), PairTimetable = context.PairTimetables.FirstOrDefault(a => a.Id == 2) });
            context.Timetables.Add(new Timetable { Classroom = context.Classrooms.FirstOrDefault(a => a.Id == 3), TeachSubj = context.TeachSubjs.FirstOrDefault(a => a.Id == 3), PairTimetable = context.PairTimetables.FirstOrDefault(a => a.Id == 2) });
            context.Timetables.Add(new Timetable { Classroom = context.Classrooms.FirstOrDefault(a => a.Id == 2), TeachSubj = context.TeachSubjs.FirstOrDefault(a => a.Id == 2), PairTimetable = context.PairTimetables.FirstOrDefault(a => a.Id == 3) });
            context.Timetables.Add(new Timetable { Classroom = context.Classrooms.FirstOrDefault(a => a.Id == 3), TeachSubj = context.TeachSubjs.FirstOrDefault(a => a.Id == 4), PairTimetable = context.PairTimetables.FirstOrDefault(a => a.Id == 3) });

            context.Timetables.Add(new Timetable { Classroom = context.Classrooms.FirstOrDefault(a => a.Id == 1), TeachSubj = context.TeachSubjs.FirstOrDefault(a => a.Id == 5), PairTimetable = context.PairTimetables.FirstOrDefault(a => a.Id == 5) });
            context.Timetables.Add(new Timetable { Classroom = context.Classrooms.FirstOrDefault(a => a.Id == 2), TeachSubj = context.TeachSubjs.FirstOrDefault(a => a.Id == 1), PairTimetable = context.PairTimetables.FirstOrDefault(a => a.Id == 6) });
            context.Timetables.Add(new Timetable { Classroom = context.Classrooms.FirstOrDefault(a => a.Id == 3), TeachSubj = context.TeachSubjs.FirstOrDefault(a => a.Id == 3), PairTimetable = context.PairTimetables.FirstOrDefault(a => a.Id == 6) });
            context.Timetables.Add(new Timetable { Classroom = context.Classrooms.FirstOrDefault(a => a.Id == 2), TeachSubj = context.TeachSubjs.FirstOrDefault(a => a.Id == 2), PairTimetable = context.PairTimetables.FirstOrDefault(a => a.Id == 7) });
            context.Timetables.Add(new Timetable { Classroom = context.Classrooms.FirstOrDefault(a => a.Id == 3), TeachSubj = context.TeachSubjs.FirstOrDefault(a => a.Id == 4), PairTimetable = context.PairTimetables.FirstOrDefault(a => a.Id == 7) });
            context.SaveChanges();

            context.GroupTimetables.Add(new GroupTimetable { Group = context.Groups.FirstOrDefault(a => a.Id == 1), Timetable = context.Timetables.FirstOrDefault(a => a.Id == 1) });
            context.GroupTimetables.Add(new GroupTimetable { Group = context.Groups.FirstOrDefault(a => a.Id == 2), Timetable = context.Timetables.FirstOrDefault(a => a.Id == 1) });
            context.GroupTimetables.Add(new GroupTimetable { Group = context.Groups.FirstOrDefault(a => a.Id == 1), Timetable = context.Timetables.FirstOrDefault(a => a.Id == 2) });
            context.GroupTimetables.Add(new GroupTimetable { Group = context.Groups.FirstOrDefault(a => a.Id == 2), Timetable = context.Timetables.FirstOrDefault(a => a.Id == 3) });
            context.GroupTimetables.Add(new GroupTimetable { Group = context.Groups.FirstOrDefault(a => a.Id == 1), Timetable = context.Timetables.FirstOrDefault(a => a.Id == 4) });
            context.GroupTimetables.Add(new GroupTimetable { Group = context.Groups.FirstOrDefault(a => a.Id == 2), Timetable = context.Timetables.FirstOrDefault(a => a.Id == 5) });

            context.GroupTimetables.Add(new GroupTimetable { Group = context.Groups.FirstOrDefault(a => a.Id == 1), Timetable = context.Timetables.FirstOrDefault(a => a.Id == 6) });
            context.GroupTimetables.Add(new GroupTimetable { Group = context.Groups.FirstOrDefault(a => a.Id == 2), Timetable = context.Timetables.FirstOrDefault(a => a.Id == 6) });
            context.GroupTimetables.Add(new GroupTimetable { Group = context.Groups.FirstOrDefault(a => a.Id == 1), Timetable = context.Timetables.FirstOrDefault(a => a.Id == 7) });
            context.GroupTimetables.Add(new GroupTimetable { Group = context.Groups.FirstOrDefault(a => a.Id == 2), Timetable = context.Timetables.FirstOrDefault(a => a.Id == 8) });
            context.GroupTimetables.Add(new GroupTimetable { Group = context.Groups.FirstOrDefault(a => a.Id == 1), Timetable = context.Timetables.FirstOrDefault(a => a.Id == 9) });
            context.GroupTimetables.Add(new GroupTimetable { Group = context.Groups.FirstOrDefault(a => a.Id == 2), Timetable = context.Timetables.FirstOrDefault(a => a.Id == 10) });
            context.SaveChanges();
        }

    }
}
