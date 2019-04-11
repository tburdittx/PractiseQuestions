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
    class UserCommandRepository : CommandRepositoryBase, IUserCommandRepository
    {
        public UserCommandRepository(Lazy<IConfiguration> configuration) : base(configuration)
        {
        }

        public Task<long> Create(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<long> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<long> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
