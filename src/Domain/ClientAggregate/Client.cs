﻿using Domain.ClientAggregate.Events;
using System;

namespace Domain
{

    public record Client : Aggregate<Client, Guid, ClientEventBase>
    {
        public static Client Empty = new Client()
        {
            CreationDate = DateTime.MinValue,
            Id = Guid.Empty,
            HomeAddress = null,
            Lastname = null,
            Firstname = null
        };

        public Name Lastname { get; init; }

        public Name Firstname { get; init; }

        public Address HomeAddress { get; init; }
       
        public static Client Create(Guid guid ,string Firstname, string Lastname, Address address)
        {
            return Empty.Dispatch(new ClientCreated(guid, new Name(Firstname), new Name(Lastname), address));
        }

        public Client UpdateAddress(Address address)
        {
            if (address.City == "Nantes")
            {
                throw new InvalidOperationException("No go zone detected !");
            }

            return Dispatch(new ClientAddressUpdated(Id, address));
        }

        public override Client Apply(ClientEventBase @event) => @event switch
        {
            ClientCreated e => this with
            {
                Id = e.AggregateId,
                Firstname = e.Firstname,
                Lastname = e.Lastname,
                HomeAddress = e.Address,
                CreationDate = e.CreationDate
            },
            ClientAddressUpdated e => this with { HomeAddress = e.Address },
            _ => throw new NotImplementedException()
        };
    }
}
