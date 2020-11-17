using Domain;
using System;
using Xunit;

namespace ApplicationService.Tests
{
    public class ApplicationServiceTests
    {
        [Fact]
        public void ApplicationService_CreateClientAndUpdateAddress()
        {
            var service = new ApplicationService();

            var newClientId = Guid.NewGuid();

            service.CreateClient(new CreateClientCommand(newClientId, "Paul", "Lennon", new Address(null, "avenue", 100, "Amiens")));
            service.UpdateClientAddress(new UpdateClientAddressCommand(newClientId, new Address(null, "passage", 62730, "Marck")));
            service.UpdateClientAddress(new UpdateClientAddressCommand(newClientId, new Address(null, "route", 92100, "Boulogne")));
        }
    }
}
