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

        private readonly IClientsRepository _clientsRepository; 

        public ClientsController(IClientsRepository clientsRepository)
        {
            _clientsRepository = clientsRepository;
        }

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
                clientModels.Add(MapToClientModel(client));
            }

            var allClientsToJson = ClientToJson(clientModels);
            return Ok(allClientsToJson);
        }

        
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
            var clientModel = MapToClientModel(raksClient);
            var allClientsToJson = ClientToJson(clientModel);
            return Ok(allClientsToJson);
        }

        #region Map
        private ClientModel MapToClientModel(R3_CONTACTS client)
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
                EMail = GetEmailList(client),
                PhoneNumber = GetPhoneNumber(client)
            };
        }
        #endregion

        #region GetContactDetails
        private IEnumerable<string> GetEmailList(R3_CONTACTS raksClient)
        {
            var raksEmailList = raksClient.R3_CONTACT_WEB_ADDRESSES.Where(e => e.CONTACT_ID == raksClient.ID).Select(e => e.ADDRESS).ToList();
            return raksEmailList;
        }

        private IEnumerable<string> GetPhoneNumber(R3_CONTACTS raksClient)
        {
            var raksEmailList = raksClient.R3_CONTACT_PHONES.Where(e => e.CONTACT_ID == raksClient.ID).Select(e => e.NUMBER).ToList();
            return raksEmailList;
        }
        #endregion


        private string ClientToJson<T>(T Client)
        {
            return JsonConvert.SerializeObject(Client, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }
    }
}
