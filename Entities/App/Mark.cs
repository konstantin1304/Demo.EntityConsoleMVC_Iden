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
    [Table("tbMarks")]
    public class Mark : DbEntity
    {
        [Range(1, 12)]
        public int MarkStud { get; set; }
        public virtual Student Student { get; set; }
        public virtual TeachSubj TeachSubj { get; set; }
        public override string ToString()
        {
            return $"{MarkStud}";
        }
    }
}
