using System;

namespace Domain.ClientAggregate.Events
{
    public abstract class ClientEventBase : AggregateDomainEvent<Guid>
    {
        public ClientEventBase(Guid id) : base(id)
        {

        }
    }
}
