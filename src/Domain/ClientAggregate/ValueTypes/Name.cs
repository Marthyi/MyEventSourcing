using System;

namespace Domain
{
    public record Name : ValueType
    {
        public string Value { get; }

        public Name(string value) => Value = value;

        public override string ToString() => Value;

        public override bool IsValidOrThrow()
        {
            return Value?.Length switch
            {
                null => throw new ArgumentNullException(nameof(Value)),
                < 3 => throw new ArgumentException($"{nameof(Value)} is too short"),
                _ => true
            };
        }
    }
}
