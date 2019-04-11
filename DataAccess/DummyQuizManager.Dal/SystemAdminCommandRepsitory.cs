using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.Extensions.Configuration;
using PracticeQuestions.Dal.Interface;

namespace PracticeQuestions.Dal
{
    class SystemAdminCommandRepsitory : CommandRepositoryBase, ISystemAdminCommandRepository
    {
        public SystemAdminCommandRepsitory(Lazy<IConfiguration> configuration) : base(configuration)
        {
        }

        public Task<long> Create(SystemAdmin entity)
        {
            throw new NotImplementedException();
        }

        public Task<long> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<long> Update(SystemAdmin entity)
        {
            throw new NotImplementedException();
        }
    }
}
