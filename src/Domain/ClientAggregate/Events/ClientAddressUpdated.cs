using System;

namespace Domain.ClientAggregate.Events
{


    public class ClientAddressUpdated : ClientEventBase
    {
        public ClientAddressUpdated(Guid clientId, Address address) : base(clientId)
        {
            Address = address;
        }


        public Address Address { get; }
    }

   
}
