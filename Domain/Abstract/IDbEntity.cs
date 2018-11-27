using System.ComponentModel.DataAnnotations;

namespace Demo.EntityConsole.Abstract
{
    public interface IDbEntity
    {
        [Key]
        int Id { get; set; }
    }
}
