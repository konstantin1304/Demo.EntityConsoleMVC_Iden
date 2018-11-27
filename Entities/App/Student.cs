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
    [Table("tbStudents")]
    public class Student : DbEntity
    {
        [StringLength(64)]
        public string FirstName { get; set; }
        [StringLength(64)]
        public string MiddleName { get; set; }
        [StringLength(64)]
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int LogbookNumber { get; set; }
        public string Email { get; set; }
        public virtual Group Group { get; set; }
        public virtual Address Address { get; set; }
        public virtual List<Phone> Phones { get;set;}
        public virtual List<Mark> Marks { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName} {Birthday} {LogbookNumber} {Email}";
        }

    }
}
