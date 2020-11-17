namespace ApplicationService
{
    public class ApplicationService
    {


        public ApplicationService()
        {

        }

        public void CreerClient(CreateClientCommand command)
        {
            var handler = new CreateClientCommandHandler(new ClientRepository());
            handler.Handle(command);
        }

        public void ChangeDomiciliationClient(ChangerDomicileClientCommand command)
        {
            var handler = new ChangerDomicileClientCommandHandler(new ClientRepository());
            handler.Handle(command);


        }
    }
}
