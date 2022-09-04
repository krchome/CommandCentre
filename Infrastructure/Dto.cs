using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;

namespace CommandCentre.Infrastructure
{
    public record OrderDto(Guid Id, string Address, int Quantity, DateTimeOffset CreatedDate);
    public record CreateOrderDto([Required] string Address, [Range(0, 1000)] int Quantity);
    public record UpdateOrderDto([Required] string Address, [Range(0, 1000)] int Quantity);
}

