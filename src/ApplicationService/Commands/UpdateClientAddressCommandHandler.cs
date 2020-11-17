using Domain;

namespace ApplicationService
{
    public class UpdateClientAddressCommandHandler
    {
        private readonly ClientRepository _clientRepository;

        public UpdateClientAddressCommandHandler(ClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void Handle(UpdateClientAddressCommand command)
        {
            Client client = _clientRepository.GetEntity(command.ClientId);

            client = client.UpdateAddress(command.Adresse);

            _clientRepository.SaveAggregateEvents(client);
        }
    }
}
