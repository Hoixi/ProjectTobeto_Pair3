﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.CourseCategoryResponses
{
    public class CreatedCourseCategoryResponse
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
    }
}
