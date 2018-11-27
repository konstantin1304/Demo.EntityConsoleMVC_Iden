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
    [Table("tbGroup")]
    public class Group : DbEntity
    {
        [StringLength(64)]
        public string Name { get; set; }
        public virtual Speciality Speciality { get; set; }
        public virtual List<GroupTimetable> GroupTimetables { get; set; }
        public virtual List<Student> Students { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
