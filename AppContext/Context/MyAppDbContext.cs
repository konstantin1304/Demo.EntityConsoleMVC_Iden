using Entities.App;
using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace Demo.AppContext
{
    public class MyAppDbContext:DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupTimetable> GroupTimetables { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<PairTimetable> PairTimetables { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeachSubj> TeachSubjs { get; set; }
        public DbSet<Timetable> Timetables { get; set; }



        public MyAppDbContext(string ConnStrOrDatabaseName)
            :base(ConnStrOrDatabaseName)
        {
            Database.SetInitializer(new MyAppDbContextInitializer());
        }
    }
 
}
