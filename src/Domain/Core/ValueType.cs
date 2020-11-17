using System;

namespace Domain
{
    public abstract record ValueType
    {
        public abstract bool IsValidOrThrow();      
    }
}
