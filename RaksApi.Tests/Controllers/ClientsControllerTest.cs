using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RaksApi.Controllers;
using RaksApi.Models;
using RaksApi.Repositories.Interfaces;
using System.Web.Http;
using System.Web.Http.Results;

namespace RaksApi.Tests.Controllers
{
    [TestClass]
    public class ClientsControllerTest
    {
        
        private static readonly IQueryable<R3_CONTACTS> clientModels = new List<R3_CONTACTS>()
            {
                new R3_CONTACTS{ ID= 1, FULL_NAME= "Acme1 ltd.", SHORT_NAME= "Acme1", PROVINCE="Mazowieckie", STREET="Al. Jerozolimskie", PLACE="Warsaw", BUILDING_NUMBER= "1", APARTMENT_NUMBER= "5", ZIPCODE="00-001"},
                new R3_CONTACTS{ ID= 2, FULL_NAME= "Acme2 ltd.", SHORT_NAME= "Acme2", PROVINCE="Mazowieckie", STREET="Al. Jerozolimskie", PLACE="Warsaw", BUILDING_NUMBER= "2", APARTMENT_NUMBER= "5", ZIPCODE="00-001"},
                new R3_CONTACTS{ ID= 1, FULL_NAME= "Acme3 ltd.", SHORT_NAME= "Acme3", PROVINCE="Mazowieckie", STREET="Al. Jerozolimskie", PLACE="Warsaw", BUILDING_NUMBER= "3", APARTMENT_NUMBER= "5", ZIPCODE="00-001"},
                new R3_CONTACTS{ ID= 1, FULL_NAME= "Acme4 ltd.", SHORT_NAME= "Acme4", PROVINCE="Mazowieckie", STREET="Al. Jerozolimskie", PLACE="Warsaw", BUILDING_NUMBER= "4", APARTMENT_NUMBER= "5", ZIPCODE="00-001"},
                new R3_CONTACTS{ ID= 1, FULL_NAME= "Acme5 ltd.", SHORT_NAME= "Acme5", PROVINCE="Mazowieckie", STREET="Al. Jerozolimskie", PLACE="Warsaw", BUILDING_NUMBER= "5", APARTMENT_NUMBER= "5", ZIPCODE="00-001"},
                new R3_CONTACTS{ ID= 1, FULL_NAME= "Acme6 ltd.", SHORT_NAME= "Acme6", PROVINCE="Mazowieckie", STREET="Al. Jerozolimskie", PLACE="Warsaw", BUILDING_NUMBER= "6", APARTMENT_NUMBER= "5", ZIPCODE="00-001"}
            }.AsQueryable();


        [TestMethod]
        public void GetAllClients_ShouldReturnAllClients()
        {
            var valueServiceMock = new Mock<IClientsRepository>();
            valueServiceMock.Setup(service => service.GetAll())
                .Returns(clientModels);

            var controller = new ClientsController(valueServiceMock.Object);
            var values = controller.Get();
            var valuesCast = values as OkNegotiatedContentResult<List<ClientModel>>;

            Assert.AreEqual(clientModels.Count(), valuesCast.Content.Count());
        }

        [TestMethod]
        public void GetOneClient_ShouldReturnOneClientId()
        {
            int id = 2;
            var client = clientModels.SingleOrDefault(c => c.ID == id);
            var valueServiceMock = new Mock<IClientsRepository>();
            valueServiceMock.Setup(service => service.GetById(id))
                .Returns(client);

            var controller = new ClientsController(valueServiceMock.Object);
            var value = controller.Get(id);
            var valueCast = value as OkNegotiatedContentResult<ClientModel>;

            Assert.AreEqual(2, valueCast.Content.Id);
        }

    }
}
