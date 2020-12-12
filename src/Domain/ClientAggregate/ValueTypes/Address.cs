using Domain.Exceptions;
using System;

namespace Domain
{
    public record Address : ValueType
    {
        private string _street;
        public string Street
        {
            get => _street;
            init
            {
                _street = value?.Length switch
                {
                    null => throw new NullPropertyException(nameof(Street)),
                    < 3 => throw new InvalidPropertyValueException(nameof(Street), value, "value is too short"),
                    _ => value
                };
            }
        }

        public int? StreetNumber { get; init; }
        public string City { get; init; }
        public int CityNumber { get; init; }


        public Address(int? streetNumber, string street, int cityNumber, string city)
        {
            StreetNumber = streetNumber;
            Street = street;
            CityNumber = cityNumber;
            City = city;
        }

    }
}
