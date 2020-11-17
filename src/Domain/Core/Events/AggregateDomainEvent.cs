namespace Domain
{
    public class AggregateDomainEvent<TAggregateId> : DomainEvent
    {

        public AggregateDomainEvent(TAggregateId id)
        {
            AggregateId = id;
        }

        public TAggregateId AggregateId { get; init; }
    }
}
