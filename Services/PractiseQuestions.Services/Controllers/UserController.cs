using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using PracticeQuestions.Dal.Interface;

namespace PractiseQuestions.Services.Controllers
{
    [Route("api/[controller]")]
    public class UserController:ControllerBase
    {
        public IUserQueryRepository UserQueryRepository { get; }

        public UserController(IUserQueryRepository userQueryRepository)
        {
            UserQueryRepository = userQueryRepository;
        }
        [HttpGet("ReadAllUsers")]
        public Task<IEnumerable<User>> ReadAllQuestions()
            
        {
            var result = this.UserQueryRepository.ReadAllAsync();
            return result;
        }
    }
}
