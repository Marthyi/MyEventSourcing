using Domain;
using Domain.ClientAggregate.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationService
{
    public class ClientRepository : GuidRepositoryBase<Client, ClientEventBase>
    {
        static List<ClientEventBase> _events = new List<ClientEventBase>();

        public override Client GetEntity(Guid id)
        {
            ClientEventBase[] events = _events.Where(p => p.AggregateId == id).ToArray();

            if (events is { Length: 0 })
            {
                return null;
            }

            Client client = Client.Empty;

            foreach (ClientEventBase @event in events)
            {
                client = client.Apply(@event);
            }

            return client;
        }

        public override void Save(ClientEventBase @event)
        {
            _events.Add(@event);
        }
    }
}
