using Domain.ClientAggregate.Events;
using System;
using Xunit;

namespace Domain.Tests.ClientAggregate
{
    public class ClientTest
    {
        [Fact]
        public void Client_Ctor_InstanciateClient_Running()
        {
            Client client = new Client()
            {
                CreationDate = DateTime.Now,
                Domicile = new Adresse(25, "rue de la victoire", 92100, "Boulogne-Billancourt"),
                Id = Guid.NewGuid(),
                Prénom = new Name("Sean"),
                Nom = new Name("Paul")
            };

            Assert.Equal("Sean", client.Prénom.Value);
            Assert.Equal("Paul", client.Nom.Value);

        }

        [Fact]
        public void Client_ChangeAdress_Running()
        {
            var adresse = new Adresse(25, "rue de la victoire", 92100, "Boulogne-Billancourt");

            var client = new Client()
            {
                CreationDate = DateTime.Now,
                Domicile = adresse,
                Id = Guid.NewGuid(),
                Prénom = new Name("Sean"),
                Nom = new Name("Paul")
            };


            client = client.ChangeAdresse(adresse with { City = "PARIS 15", CityNumber = 75100 });

            Assert.Equal("Sean", client.Prénom.Value);
            Assert.Equal("Paul", client.Nom.Value);

            Assert.Equal("PARIS 15", client.Domicile.City);
            Assert.Single(client.DomainEvents);
            Assert.True(client.DomainEvents[0] is ChangementDomicileClient);

        }

    }
}
