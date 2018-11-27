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
    [Table ("tbAddress")]
    public class Address :DbEntity
    {
        public int ZipCode { get; set; }
        [StringLength(50)]
        public string Region { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(5)]
        public string StreetKind { get; set; }
        [StringLength(60)]
        public string Street { get; set; }
        [StringLength(10)]
        public string House { get; set; }
        [StringLength(10)]
        public string Building { get; set; }
        [StringLength(10)]
        public string Flat { get; set; }
        public virtual List<Student> Students { get; set; }

        public override string ToString()
        {
            return $"{ZipCode} {Region} {City} {StreetKind} {Street} {House} {Building} {Flat}";
        }

    }
}
