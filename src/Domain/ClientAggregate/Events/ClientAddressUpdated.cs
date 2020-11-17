using System;

namespace Domain.ClientAggregate.Events
{


    public class ClientAddressUpdated : ClientEventBase
    {
        public ClientAddressUpdated(Guid clientId, Address adresse) : base(clientId)
        {
            Adresse = adresse;
        }


        public Address Adresse { get; }
    }

   
}
