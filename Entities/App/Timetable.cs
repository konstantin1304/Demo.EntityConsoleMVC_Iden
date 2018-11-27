using Demo.EntityConsole.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.App
{
    [Table ("tbTimetable")]
    public class Timetable : DbEntity
    {
        public virtual Classroom Classroom { get; set; }
        public virtual TeachSubj TeachSubj { get; set; }
        public virtual PairTimetable PairTimetable { get; set; }
        public virtual List<GroupTimetable> GroupTimetables { get; set; }

        public override string ToString()
        {
            return "Классная комната :" + Classroom?.ToString() + "Преподаватель и предмет: " + TeachSubj.ToString() + "Пара: " + PairTimetable.ToString(); 
        }

    }
}
