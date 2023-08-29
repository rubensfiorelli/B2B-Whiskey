using Whiskey.Domain.Primitives;
using Whiskey.Domain.ValueObjects;

namespace Whiskey.Domain.Entities
{
    public sealed class Costumer : BaseEntity
    {
        public Costumer(string firstName, string lastName, string email, string whatsApp) : base()
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            WhatsApp = whatsApp;
            IsDeleted = false;

            Orders = new List<Order>();

        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string WhatsApp { get; private set; }
        public bool IsDeleted { get; private set; }
        public List<Order>? Orders { get; set; }
        public DeliveryAddress? DeliveryAddress { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            IsDeleted = true;
        }

        public void SetFields(string firstName, string lastName, string email, string whatsApp)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            WhatsApp = whatsApp;
        }
    }
}
