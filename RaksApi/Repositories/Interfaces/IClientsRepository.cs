using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaksApi.Repositories.Interfaces
{
    interface IClientsRepository<T> : IBaseRepository<T> where T : R3_CONTACTS
    {

    }
}
