namespace Whiskey.Domain.ValueObjects
{
    public record DeliveryAddress
    {
        public DeliveryAddress(int number, string street, string city, string state, string zipCode)
        {
            Number = number;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public int Number { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
    }
}
