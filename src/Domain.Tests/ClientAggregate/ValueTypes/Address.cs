using Domain.Exceptions;
using System;
using Xunit;

namespace Domain
{

    public class AddressTest
    {
        [Fact]
        public void Address_Ctor_InstantiateInvalidData_ShouldThrowException()
        {
            Assert.Throws<NullPropertyException>(() => new Address(25, null, 75100, "PARIS"));
        }

        [Fact]
        public void Address_Ctor_InstantiateValidData_Run()
        {
            var address = new Address(25, "Rue Foch", 75100, "Paris");
        }
    }
}
