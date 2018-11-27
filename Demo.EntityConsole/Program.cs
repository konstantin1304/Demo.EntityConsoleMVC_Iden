using Demo.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo.EntityConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teacher t = new Teacher
            //{
            //    FirstName = "Коля",
            //    LastName = "Петров",
            //    MiddleName = "Васильевич",
            //    Department = Unit.DepartmentsRepository.AllItems.FirstOrDefault(x => x.Name == "PROGRAMMING")
            //};

            //Unit.TeachersRepository.AddItem(t);

            foreach(var t in Unit.TeachersRepository.AllItems.OrderBy(z=>z.LastName).ToList())
            {
                Console.WriteLine($"{t.FirstName} {t.MiddleName} {t.LastName} {t.Department.Name}");
            }
            Console.ReadKey();
        }
    }
}
