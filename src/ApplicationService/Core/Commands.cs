using Domain;
using System;

namespace ApplicationService
{
    public abstract class Command
    {

    }

    public record UpdateClientAddressCommand(Guid ClientId, Address Adresse);

    public record CreateClientCommand(Guid ClientId, string FirstName, string LastName, Address adresse);
}
