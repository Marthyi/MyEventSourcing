using System;

namespace Domain.Exceptions
{
    public class InvalidPropertyValueException : Exception
    {

        public InvalidPropertyValueException(string propertyName, string value) : base($"Property {propertyName} cannot have value '{value}'.")
        {

        }

        public InvalidPropertyValueException(string propertyName, string value, string extraMessage) :
            base($"Property {propertyName} cannot have value '{value}'. {extraMessage}")
        {

        }
    }
}
