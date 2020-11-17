using Domain.ClientAggregate.Events;
using System;

namespace Domain
{

    public record Client : Aggregate<Client, Guid, ClientEventBase>
    {
        public static Client Empty = new Client()
        {
            CreationDate = DateTime.MinValue,
            Id = Guid.Empty,
            Domicile = null,
            Nom = null,
            Prénom = null
        };

        public Name Nom { get; init; }
        public Name Prénom { get; init; }

        public Adresse Domicile { get; init; }

        public Client() { }

        public static Client Create(Guid guid ,string Firstname, string Lastname, Adresse adresse)
        {
            return Empty.Dispatch(new CréationClient(guid, new Name(Firstname), new Name(Lastname), adresse));
        }

        public Client ChangeAdresse(Adresse address)
        {
            if (address.City == "Nantes")
            {
                throw new InvalidOperationException("Cette ville ne rentre pas dans les critères");
            }

            return Dispatch(new ChangementDomicileClient(Id, address));
        }

        public override Client Apply(ClientEventBase @event) => @event switch
        {
            CréationClient e => this with
            {
                Id = e.AggregateId,
                Prénom = e.Prénom,
                Nom = e.Nom,
                Domicile = e.Adresse,
                CreationDate = e.CreationDate
            },
            ChangementDomicileClient e => this with { Domicile = e.Adresse },
            _ => throw new NotImplementedException()
        };
    }
}
