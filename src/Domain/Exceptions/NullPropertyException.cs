using System;

namespace Domain.Exceptions
{
    public class NullPropertyException : Exception
    {
        public NullPropertyException(string propertyName) : base($"Property {propertyName} cannot be null")
        {

        }
    }
}
