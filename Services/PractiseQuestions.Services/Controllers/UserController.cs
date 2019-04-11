using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeQuestions.Dal.Interface;

namespace PractiseQuestions.Services.Controllers
{
    [Route("api/[controller]")]
    public class UserController:ControllerBase
    {
        public IUserQueryRepository userQueryRepository { get; }
    }
}
