using RaksApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaksApi.ExtensionMethods
{
    public static class ClientMapper
    {
        #region Map
        public static ClientModel MapToClientModel(this R3_CONTACTS client)
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
                EMail = client.R3_CONTACT_WEB_ADDRESSES.Select(w => w.ADDRESS),
                PhoneNumber = client.R3_CONTACT_PHONES.Select(w => w.NUMBER)
            };
        }
        #endregion
    }
}