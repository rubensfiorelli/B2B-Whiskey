using Whiskey.Domain.Primitives;

namespace Whiskey.Domain.Entities
{
    public sealed class Product : BaseEntity
    {
        public Product(string title, string description, decimal salePrice, Guid categoryId) : base()
        {
            Title = title;
            Description = description;
            SalePrice = salePrice;
            CategoryId = categoryId;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal SalePrice { get; private set; }
        public Guid CategoryId { get; private set; }
        public Category? Category { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public void SetFields(string title, string description, decimal salePrice)
        {
            Title = title;
            Description = description;
            SalePrice = salePrice;

        }
    }
}
