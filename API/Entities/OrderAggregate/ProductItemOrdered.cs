using Microsoft.EntityFrameworkCore;

namespace API.Entities.OrderAggregate
{
    [Owned]
    public class ProductItemOrdered
    {
        public int ProducId { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
    }
}