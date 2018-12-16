using RaksApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace RaksApi.Repositories
{
    public class ClientsRepository : BaseRepository<R3_CONTACTS>, IClientsRepository
    {
        
        public ClientsRepository(Entities context):base(context)
        {
            
        }

        public override IQueryable<R3_CONTACTS> GetAll()
        {
            return _dbSet.Include(m => m.R3_CONTACT_WEB_ADDRESSES).Include(m => m.R3_CONTACT_PHONES);
        }
    }
}