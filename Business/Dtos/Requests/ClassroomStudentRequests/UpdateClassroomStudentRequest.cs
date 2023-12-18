﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.ClassroomStudentRequests
{
    public class UpdateClassroomStudentRequest
    {
        public int Id { get; set; }
        public int ClassroomGroupId { get; set; }
        public int StudentId { get; set; }
    }
}
