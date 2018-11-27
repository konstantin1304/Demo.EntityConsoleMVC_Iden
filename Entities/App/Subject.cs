using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Demo.EntityConsole.Abstract;

namespace Entities.App
{
    [Table("tbSubjects")]
    public class Subject : DbEntity
    {
        [StringLength(64)]
        public string Name { get; set; }
        public virtual List<TeachSubj> TeachSubjs { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}   
