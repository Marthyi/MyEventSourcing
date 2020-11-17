using Domain.ClientAggregate.Events;
using System;
using Xunit;

namespace Domain.Tests.ClientAggregate
{
    public class ClientTest
    {
        [Fact]
        public void Client_ChangeAddress()
        {
            var address = new Address(25, "rue de la victoire", 92100, "Boulogne-Billancourt");
            var client = Client.Create(Guid.NewGuid(), "Sean", "PAUL", address);


            client = client.UpdateAddress(address with { City = "PARIS 15", CityNumber = 75100 });

            Assert.Equal("PARIS 15", client.HomeAddress.City);
            Assert.Equal(75100, client.HomeAddress.CityNumber);
            Assert.True(client.DomainEvents is { Count: 2 });
            Assert.True(client.DomainEvents[1] is ClientAddressUpdated);
        }

    }
}
