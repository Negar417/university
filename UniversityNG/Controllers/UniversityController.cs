using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityNG.models;
using UniversityNG.Data;
using Microsoft.EntityFrameworkCore;

namespace UniversityNG.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //university
    public class UniversityController : ControllerBase
    {
        private readonly DataContext _context;
        public UniversityController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetCourse()
        {
            return Ok(await _context.Course.ToListAsync());
        }
        [Route("{id}")]
        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetCourse(int id)
        {
            return Ok(await _context.Course.FindAsync(id));
        }
        [HttpPost]
        public async Task<ActionResult<List<Course>>> CreateCourse(Course courseData)
        {
            _context.Course.Add(courseData);
            await _context.SaveChangesAsync();
            return Ok(await _context.StudentB.ToListAsync());
        }
       
        [HttpPut]
        public async Task<ActionResult<List<Course>>> UpdateCourse(Course courseData)
        {

            var dbCourse = await _context.Course.FindAsync(courseData.Id);
            if (dbCourse == null)
                return BadRequest("student not found");
            dbCourse.CourseName = courseData.CourseName;
            dbCourse.TeacherName = courseData.TeacherName;
            //
            //
            //
            await _context.SaveChangesAsync();
            return Ok(await _context.StudentB.ToListAsync());

        }
        [Route("{id}")]
        [HttpDelete]
        public async Task<ActionResult<List<Course>>> DeleteCourse(int id)
        {
            var dbCourse = await _context.Course.FindAsync(id);
            if (dbCourse == null)
                return BadRequest("student not found");

            _context.Course.Remove(dbCourse);
            await _context.SaveChangesAsync();

            return Ok(await _context.StudentB.ToListAsync());

        }

    }
}
