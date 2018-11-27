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
    [Table("tbPhones")]
    public class Phone : DbEntity
    {
        [StringLength(64)]
        public string PhoneNumber { get; set; }
        public virtual Student Student { get; set; }
        public override string ToString()
        {
            return PhoneNumber;
        }

    }
}
