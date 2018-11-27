using Demo.EntityConsole.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.App
{
    [Table("tbTeachSubj")]
    public class TeachSubj : DbEntity
    {
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }

        public virtual List<Mark> Marks { get; set; }
        
        public virtual List<Timetable> Timetables { get; set; }

        public override string ToString()
        {
            return $"Преподаватель: {Teacher.ToString()} || Предмет: {Subject.ToString()} || ";
        }

    }
}
