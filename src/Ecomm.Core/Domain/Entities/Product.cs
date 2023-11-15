using Ecomm.Common.ValueObjects;
using Ecomm.Core.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Ecomm.Core.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        [Precision(14, 2)]
        public decimal Price { get; set; }
        public int? DepositAmount { get; set; }
        public int? DepositType { get; set; }
        public Guid LocationId { get; set; }
        public Location DeliveryLocation { get; set; }
        public Guid OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
