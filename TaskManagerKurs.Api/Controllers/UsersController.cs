using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagerKurs.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagerKurs.Api.Models.Data;
using TaskManagerKurs.Api.Models;

namespace TaskManagerKurs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationContext _db;
        public UsersController(ApplicationContext db)
        {
            _db = db;
        }
        [HttpPost("create")]
        public IActionResult CreateUser([FromBody] UserModel userModel)
        {
            if (userModel !=null)
            {
                User newUuser = new User(userModel.FirstName, userModel.LastName,
                    userModel.Email, userModel.Password, userModel.Status, userModel.Phone,
                    userModel.Photo);
                _db.Users.Add(newUuser);
                _db.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
        [HttpGet("test")]
        public IActionResult TestApi()
        {
            return Ok("Всем привет");
        }
    }
}
