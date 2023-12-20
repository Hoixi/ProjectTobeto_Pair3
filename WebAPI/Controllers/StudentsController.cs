﻿using Business.Abstracts;
using Business.Dtos.Requests.StudentRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromQuery] CreateStudentRequest createStudentRequest)
        {
            var result = await _studentService.AddAsync(createStudentRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _studentService.GetAllAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromQuery] UpdateStudentRequest updateStudentRequest)
        {
            var result = await _studentService.UpdateAsync(updateStudentRequest);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int Id)
        {
            var result = await _studentService.DeleteAsync(Id);
            return Ok(result);
        }
    }
}