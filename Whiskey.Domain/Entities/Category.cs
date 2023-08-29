using Whiskey.Domain.Primitives;

namespace Whiskey.Domain.Entities
{
    public sealed class Category : BaseEntity
    {
        public Category(string title, string description) : base()
        {
            Title = title;
            Description = description;
            IsDeleted = false;
            Products = new List<Product>();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool IsDeleted { get; private set; }
        public List<Product> Products { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public void SetFields(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
