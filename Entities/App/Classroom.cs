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
    [Table("tbClassrooms")]
    public class Classroom: DbEntity
    {
        public int ClassroomNumber{ get; set; }
        public int Capacity { get; set; }
        public int Floor { get; set; }
        public virtual List<Timetable> Timetables { get; set; }
        public override string ToString()
        {
            return $" {ClassroomNumber} ";
        }
    }
}
