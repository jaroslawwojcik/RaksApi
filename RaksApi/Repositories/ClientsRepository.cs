using RaksApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaksApi.Repositories
{
    public class ClientsRepository : BaseRepository<R3_CONTACTS>, IClientsRepository
    {
        
        public ClientsRepository(Entities context):base(context)
        {
            
        }
    }
}