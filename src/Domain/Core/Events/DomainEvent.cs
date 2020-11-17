using System;

namespace Domain
{
    public abstract class DomainEvent : IIdentity<Guid>
    {
        public DomainEvent()
        {
            Id = Guid.NewGuid();
            Name = GetType().Name;
        }

        public Guid Id { get; }

        public string Name { get; }
    }


   
}
