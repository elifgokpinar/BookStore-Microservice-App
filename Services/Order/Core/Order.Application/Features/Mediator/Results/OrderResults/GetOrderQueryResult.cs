
namespace Order.Application.Features.Mediator.Results.OrderResults
{
    public class GetOrderQueryResult
    {
        public long Id { get; set; }

        public string UserId { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
