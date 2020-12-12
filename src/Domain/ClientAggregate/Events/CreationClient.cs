using System;

namespace Domain.ClientAggregate.Events
{
    public class ClientCreated : ClientEventBase
    {
        public ClientCreated(Guid clientId, Name firstname, Name lastname, Address adress) : base(clientId)
        {
            Address = adress;
            Lastname = lastname;
            Firstname = firstname;

            CreationDate = DateTime.Now;
        }

        public DateTime CreationDate { get; init; }
        public Name Lastname { get; init; }
        public Name Firstname { get; init; }
        public Address Address { get; init; }
    }
}
