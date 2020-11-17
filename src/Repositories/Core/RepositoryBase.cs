using Domain;
using System.Collections.Generic;

namespace ApplicationService
{
    public abstract class RepositoryBase<TAggregate, TId, TEvent>
        where TAggregate : Aggregate<TAggregate, TId, TEvent>
        where TEvent : AggregateDomainEvent<TId>
    {
        public abstract TAggregate GetEntity(TId id);

        public abstract void Save(TEvent @event);

        public void Save(IEnumerable<TEvent> @events)
        {
            foreach (var @event in events)
            {
                Save(@event);
            }
        }

        public void SaveAggregateEvents(TAggregate aggregate)
        {
            foreach (var @event in aggregate.DomainEvents)
            {
                Save(@event);
            }
        }
    }
}
