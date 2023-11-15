using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecomm.Common.ValueObjects
{
    [Table("Owners")]
    public class Owner
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}