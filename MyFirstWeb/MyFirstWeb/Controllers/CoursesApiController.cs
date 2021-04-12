using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyFirstWeb.DTO;
using MyFirstWeb.Model;
using Newtonsoft.Json.Linq;

namespace MyFirstWeb.Controllers
{
    [Route("api/courses")]
    [ApiController]
    public class CoursesApiController : Controller
    {
        private List<Course> _courses;

        public CoursesApiController()
        {
            _courses = new List<Course>();
            
            _courses.Add(
                new Course(
                    0, "123", "Programiranje mrežnih aplikacija", "PMA", "Preddiplomski",
                    5, "Odjel za informatiku"
                )
            );
            _courses.Add(
                new Course(
                    1, "342", "Programiranje 2", "P2", "Preddiplomski",
                    5, "Odjel za informatiku"
                )
            );
            _courses.Add(new Course(
                    2, "456", "Primjenjena statistika", "PS", "Preddiplomski",
                    6, "Odjel za matematiku"
                )
            );
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Course>> GetAll()
        {
            return _courses;
        }

        [HttpGet("{id}")]
        public ActionResult<Course> GetOne(int id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

        [HttpPost("save")]
        public ActionResult Save([FromBody] JObject json)
        {
            var course = CourseDTO.FromJson(json); 
            _courses.Add(course);

            return Ok();
        }

        [HttpPost("save2")]
        public ActionResult<IEnumerable<Course>> Save(Course course)
        {
            _courses.Add(course);
            return _courses;
        }
    }
}