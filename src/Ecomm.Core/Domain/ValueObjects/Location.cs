using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecomm.Core.Domain.ValueObjects
{
    [Table("Locations")]
    public class Location
    {
        [Key]
        public Guid Id { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}
