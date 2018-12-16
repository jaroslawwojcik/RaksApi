using RaksApi.Repositories.Interfaces;
using System.Web.Http;
using System.Linq;
using Newtonsoft.Json;
using RaksApi.Models;
using RaksApi.ExtensionMethods;

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
            var raksClientList = _clientsRepository.GetAll()
                .Select(client => new ClientModel()
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
                    EMail = client.R3_CONTACT_WEB_ADDRESSES.Select(w => w.ADDRESS),
                    PhoneNumber = client.R3_CONTACT_PHONES.Select(w => w.NUMBER)
                })
                .ToList();
            if (raksClientList == null)
            {
                return NotFound();
            }

            return Ok(raksClientList);
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
            var clientModel = raksClient.MapToClientModel();
            return Ok(clientModel);
        }
    }
}
