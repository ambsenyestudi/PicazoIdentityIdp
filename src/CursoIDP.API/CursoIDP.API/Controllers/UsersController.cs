using CursoIDP.API.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoIDP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly List<UserViewModel> userList;

        public UsersController()
        {
            userList = new List<UserViewModel> 
            { 
                new UserViewModel 
                { 
                    EMail = "usuario@gmail.com",
                    Name = "Alejandro",
                    Telefono = "111111111"
                } 
            };
        }
        [HttpGet]
        public IEnumerable<UserViewModel> Get()
        {
            return userList;
        }
    }
}
