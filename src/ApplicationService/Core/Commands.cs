using Domain;
using System;

namespace ApplicationService
{
    public abstract class Command
    {

    }

    public record ChangerDomicileClientCommand(Guid ClientId, Adresse Adresse);

    public record CreateClientCommand(Guid ClientId, string FirstName, string LastName, Adresse adresse);
}
