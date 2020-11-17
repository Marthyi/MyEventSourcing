using Domain;
using System;

namespace ApplicationService
{
    public class CreateClientCommandHandler
    {
        private readonly ClientRepository _clientRepository;

        public CreateClientCommandHandler(ClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void Handle(CreateClientCommand command)
        {
            Client client = _clientRepository.GetEntity(command.ClientId);

            if (client != null)
            {
                throw new InvalidOperationException($"Client already exists with this Id {command.ClientId}");
            }

            client =  Client.Create(command.ClientId,command.FirstName, command.LastName, command.adresse);

            _clientRepository.SaveAggregateEvents(client);
        }
    }
}
