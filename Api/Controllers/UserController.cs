

using Api.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    
    [ApiController]
    [Route("[api/controller]")]
   
    public class UserController : ControllerBase
    {
        IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        User user=new Api.User();
        [HttpGet("{Email}")]
        
        public async Task<IActionResult> GetUser(string Email)
        {
            return Ok(userRepository.GetUser(Email));
        }
        [HttpPost]
        public async Task<IActionResult> AddUser( User user)
        {
            userRepository.AddUser(user);
            
            return Ok();
        }


    }


}
