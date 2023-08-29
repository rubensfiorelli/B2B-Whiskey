using Whiskey.Domain.Primitives;
using Whiskey.Domain.ValueObjects;

namespace Whiskey.Domain.Entities
{
    public sealed class Order : AggregateRoot
    {
        public Order(Guid customerId,
                     Guid productId,
                     string description,
                     int qty,
                     decimal totalPrice) : base()
        {
            OrderNumber = GenerateOrderNumber();
            CustomerId = customerId;
            ProductId = productId;
            Description = description;
            PostedAt = DateTime.UtcNow;
            Qty = qty;
            TotalPrice = totalPrice;

            Items = new List<OrderItem>();
            IsDeleted = false;
        }

        public string OrderNumber { get; private set; }
        public Guid CustomerId { get; private set; }
        public Guid ProductId { get; private set; }
        public string Description { get; private set; }
        public DateTime PostedAt { get; private set; }
        public int Qty { get; set; }
        public decimal FixedFreight { get; private set; }
        public decimal TotalPrice { get; private set; }
        public List<OrderItem> Items { get; private set; }
        public bool IsDeleted { get; private set; }

        public DeliveryAddress? DeliveryAddress { get; private set; }

        public void Delete()
        {
            IsDeleted = true;
        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public void SetupOrders(List<Product> products)
        {
            foreach (var product in products)
            {
                var productPrice = (product.SalePrice * Qty + FixedFreight);

                TotalPrice += productPrice;
                Items.Add(new OrderItem(product.Title, TotalPrice));

            }
        }

        private static string GenerateOrderNumber()
        {
            const string chars = "ABCDEFGHIJ";
            const string numbers = "0123456789";

            var code = new char[9];
            var random = new Random();

            for (var i = 0; i < 3; i++)
            {
                code[i] = chars[random.Next(chars.Length)];
            }

            for (var i = 4; i < 9; i++)
            {
                code[i] = numbers[random.Next(numbers.Length)];
            }

            return new string(code);
        }
    }
}
