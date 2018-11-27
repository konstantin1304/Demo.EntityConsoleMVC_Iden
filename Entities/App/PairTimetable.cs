using Demo.EntityConsole.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.App
{
    [Table("tbPairTimetable")]
    public class PairTimetable : DbEntity
    {
        public int PairNumber { get; set; }
        public bool? IsNumerator { get; set; }
        [Range(1, 7)]
        public int DayOfTheWeek { get; set; }
        public DateTime BeginPair { get; set; }
        public DateTime EndPair { get; set; }
        public virtual List<Timetable> Timetables { get; set; }
        public override string ToString()
        {
            return $" номер пары: {PairNumber} || {(IsNumerator.HasValue ? (IsNumerator.Value ? "Числитель" : "Знаменатель") : "")} День недели: {GetDayOfTheWeek(DayOfTheWeek)}";
        }

        private string GetDayOfTheWeek(int dayOfTheWeek)
        {
            switch (dayOfTheWeek)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default: return "";
            }
        }

    }
}
