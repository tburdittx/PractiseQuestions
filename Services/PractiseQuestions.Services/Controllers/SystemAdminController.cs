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
    public class SystemAdminController:ControllerBase
    {
        public ISystemAdminQueryRepository SystemAdminQueryRepository { get; }

        public SystemAdminController(ISystemAdminQueryRepository systemAdminQueryRepository)
        {
            SystemAdminQueryRepository = systemAdminQueryRepository;
        }
        [HttpGet("ReadAllSystemAdmin")]
        public Task<IEnumerable<SystemAdmin>> ReadAllQuestions()

        {
            var result = this.SystemAdminQueryRepository.ReadAllAsync();
            return result;
        }
    }
}
