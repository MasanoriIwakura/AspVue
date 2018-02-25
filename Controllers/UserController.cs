using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using spa.Models;

namespace spa.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Users> AllUsers()
        {

            return Enumerable.Range(1, 5).Select(index => new Users
            {
                Id = 1,
                Name = "TEST",
                MailAddress = "test@example.com"
            });
        }
    }
}