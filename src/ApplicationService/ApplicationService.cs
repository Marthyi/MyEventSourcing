namespace ApplicationService
{
    public class ApplicationService
    {


        public ApplicationService()
        {

        }

        public void CreateClient(CreateClientCommand command)
        {
            var handler = new CreateClientCommandHandler(new ClientRepository());
            handler.Handle(command);
        }

        public void UpdateClientAddress(UpdateClientAddressCommand command)
        {
            var handler = new UpdateClientAddressCommandHandler(new ClientRepository());
            handler.Handle(command);


        }
    }
}
