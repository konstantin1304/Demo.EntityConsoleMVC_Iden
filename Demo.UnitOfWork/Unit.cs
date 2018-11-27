using Demo.AppContext;
using Demo.Repositories;

namespace Demo.UnitOfWork
{
    public static class Unit
    {
        private static MyAppDbContext _context;

        static Unit()
        {
            _context = new MyAppDbContext("MyAppConnStr");
            AddressesRepository = new AddressesRepository(_context);
            ClassroomsRepository = new ClassroomsRepository(_context);
            DepartmentsRepository = new DepartmentsRepository(_context);
            GroupsRepository = new GroupsRepository(_context);
            GroupTimetablesRepository = new GroupTimetablesRepository(_context);
            MarksRepository = new MarksRepository(_context);
            PairTimetablesRepository = new PairTimetablesRepository(_context);
            PhonesRepository = new PhonesRepository(_context);
            SpecialitiesRepository = new SpecialitiesRepository(_context);
            StudentsRepository = new StudentsRepository(_context);
            SubjectsRepository = new SubjectsRepository(_context);
            TeachSubjsRepository = new TeachSubjsRepository(_context);
            TeachersRepository = new TeachersRepository(_context);
            TimetablesRepository = new TimetablesRepository(_context);

        }
        
        public static AddressesRepository AddressesRepository { get; }
        public static ClassroomsRepository ClassroomsRepository { get; }
        public static DepartmentsRepository DepartmentsRepository { get; }
        public static GroupsRepository GroupsRepository { get; }
        public static GroupTimetablesRepository GroupTimetablesRepository { get; }
        public static MarksRepository MarksRepository { get; }
        public static PairTimetablesRepository PairTimetablesRepository { get; }
        public static PhonesRepository PhonesRepository { get; }
        public static SpecialitiesRepository SpecialitiesRepository { get; }
        public static StudentsRepository StudentsRepository { get; }
        public static SubjectsRepository SubjectsRepository { get; }
        public static TeachersRepository TeachersRepository { get; }
        public static TeachSubjsRepository TeachSubjsRepository { get; }
        public static TimetablesRepository TimetablesRepository { get; }




}
}
