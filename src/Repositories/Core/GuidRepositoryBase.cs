using Domain;
using System;

namespace ApplicationService
{
    public abstract class GuidRepositoryBase<TAggregate, TEvent> : RepositoryBase<TAggregate, Guid, TEvent>
       where TAggregate : Aggregate<TAggregate, Guid, TEvent>
        where TEvent : AggregateDomainEvent<Guid>
    {

    }
}
