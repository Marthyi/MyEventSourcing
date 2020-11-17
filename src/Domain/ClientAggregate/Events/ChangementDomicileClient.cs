using System;

namespace Domain.ClientAggregate.Events
{


    public class ChangementDomicileClient : ClientEventBase
    {
        public ChangementDomicileClient(Guid clientId, Adresse adresse) : base(clientId)
        {
            Adresse = adresse;
        }


        public Adresse Adresse { get; }
    }

   
}
