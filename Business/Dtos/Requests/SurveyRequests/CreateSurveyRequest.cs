﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.SurveyRequests
{
    public class CreateSurveyRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
