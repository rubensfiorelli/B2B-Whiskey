using Whiskey.Domain.Primitives;

namespace Whiskey.Domain.Entities
{
    public sealed class OrderItem : BaseEntity
    {
        public OrderItem(string title, decimal price) : base()
        {
            Title = title;
            Price = price;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }


}
