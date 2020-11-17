using Domain;
using System;
using Xunit;

namespace ApplicationService.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var service = new ApplicationService();

            var newClientId = Guid.NewGuid();

            service.CreerClient(new CreateClientCommand(newClientId, "Paul", "Lennon", new Adresse(null, "avenue", 100, "Amiens")));
            service.ChangeDomiciliationClient(new ChangerDomicileClientCommand(newClientId, new Adresse(null, "passage", 62730, "Marck")));
            service.ChangeDomiciliationClient(new ChangerDomicileClientCommand(newClientId, new Adresse(null, "route", 92100, "Boulogne")));
        }
    }
}
