using RaksApi.Repositories;
using RaksApi.Repositories.Interfaces;
using System.Collections.Generic;
using System.Web.Http;
using System.Linq;
using Newtonsoft.Json;
using RaksApi.Models;

namespace RaksApi.Controllers
{
    public class ClientsController : ApiController
    {
        private static readonly Entities context = new Entities();
        private static readonly IClientsRepository<R3_CONTACTS> _clientsRepository = new ClientsRepository(context);

        /// <summary>
        /// Returns list of all Clients
        /// </summary>
        /// <returns>IEnumerable of ClientModel</returns>
        public IHttpActionResult Get()
        {
            var allClients = _clientsRepository.GetAll();
            IList<ClientModel> clientModels = new List<ClientModel>();
            if(allClients == null)
            {
                return NotFound();
            }
            foreach(var client in allClients)
            {
                clientModels.Add(mapToClientModel(client));
            }

            var allClientsToJson = ClientToJson(clientModels);
            return Ok(allClientsToJson);
        }

        // GET: api/Clients/5
        /// <summary>
        /// Returns one Client
        /// </summary>
        /// <returns>Client</returns>
        public IHttpActionResult Get(int id)
        {
            var raksClient = _clientsRepository.GetById(id);
            if (raksClient == null)
            {
                return NotFound();
            }
            var clientModel = mapToClientModel(raksClient);
            var allClientsToJson = ClientToJson(clientModel);
            return Ok(allClientsToJson);
        }

        private ClientModel mapToClientModel(R3_CONTACTS client)
        {
            return new ClientModel()
            {
                Id = client.ID,
                FullName = client.FULL_NAME,
                ShortName = client.SHORT_NAME,
                ApartamentNumber = client.APARTMENT_NUMBER,
                BuildingNumber = client.BUILDING_NUMBER,
                Street = client.STREET,
                City = client.PLACE,
                Country = client.COUNTRY,
                ZipCode = client.ZIPCODE,
                Province = client.PROVINCE,
                EMail = getEmailList(client),
                PhoneNumber = getPhoneNumber(client)
            };
        }

        private IEnumerable<string> getEmailList(R3_CONTACTS raksClient)
        {
            var raksEmailList = raksClient.R3_CONTACT_WEB_ADDRESSES.Where(e => e.CONTACT_ID == raksClient.ID).Select(e => e.ADDRESS).ToList();
            return raksEmailList;
        }

        private IEnumerable<string> getPhoneNumber(R3_CONTACTS raksClient)
        {
            var raksEmailList = raksClient.R3_CONTACT_PHONES.Where(e => e.CONTACT_ID == raksClient.ID).Select(e => e.NUMBER).ToList();
            return raksEmailList;
        }

        private string ClientToJson<T>(T Client)
        {
            return JsonConvert.SerializeObject(Client, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }
    }
}
