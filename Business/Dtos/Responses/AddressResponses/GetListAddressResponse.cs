﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.AddressResponses
{
    public class GetListAddressResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TownId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string Description { get; set; }
    }
}
