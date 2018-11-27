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
    [Table("tbSpeciality")]
    public class Speciality : DbEntity
    {
        [StringLength(64)]
        public string Name { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<Group> Groups { get; set; }
        public virtual List<TeachSubj> TeachSubjs { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

}
