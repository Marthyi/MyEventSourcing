using Domain;

namespace ApplicationService
{
    public class ChangerDomicileClientCommandHandler
    {
        private readonly ClientRepository _clientRepository;

        public ChangerDomicileClientCommandHandler(ClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void Handle(ChangerDomicileClientCommand command)
        {
            Client client = _clientRepository.GetEntity(command.ClientId);

            client = client.ChangeAdresse(command.Adresse);

            _clientRepository.Save(client.DomainEvents);
        }
    }
}
