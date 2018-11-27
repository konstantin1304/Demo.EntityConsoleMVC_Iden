using Demo.EntityConsole.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.App
{
    [Table("tbGroupTimetable")]
    public class GroupTimetable : DbEntity
    {
        public virtual Timetable Timetable { get; set;}
        public virtual Group Group { get; set;}

        public override string ToString()
        {
            return $" {Timetable} {Group} ";
        }

    }
}
