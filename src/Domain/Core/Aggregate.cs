using System;
using System.Collections.Generic;

namespace Domain
{

    public abstract record Aggregate<TAggregate, TAggregateId, TEvent> : Entity<TAggregateId>
        where TEvent : AggregateDomainEvent<TAggregateId>
        where TAggregate : Aggregate<TAggregate, TAggregateId, TEvent>
    {
        public List<TEvent> DomainEvents { get; init; }

        public Aggregate()
        {
            DomainEvents = new List<TEvent>();
        }

        public abstract TAggregate Apply(TEvent @event);


        protected TAggregate Dispatch(TEvent @event)
        {
            DomainEvents.Add(@event);
            return Apply(@event);
        }
    }
}
