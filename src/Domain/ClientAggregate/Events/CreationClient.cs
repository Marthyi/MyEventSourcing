using System;

namespace Domain.ClientAggregate.Events
{
    public class CréationClient : ClientEventBase
    {
        public CréationClient(Guid clientId, Name prénom, Name nom, Adresse adresse) : base(clientId)
        {
            Adresse = adresse;
            Nom = nom;
            Prénom = prénom;

            CreationDate = DateTime.Now;
        }

        public DateTime CreationDate { get; init; }
        public Name Nom { get; init; }
        public Name Prénom { get; init; }
        public Adresse Adresse { get; init; }
    }
}
