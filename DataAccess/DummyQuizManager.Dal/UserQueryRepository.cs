using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Entities;
using Microsoft.Extensions.Configuration;
using PracticeQuestions.Dal.Interface;

namespace PracticeQuestions.Dal
{
    public class UserQueryRepository : QueryRepositoryBase, IUserQueryRepository
    {
        private const string uspUserRead = "[dbo].[uspUserRead]";
        private const string uspUserReadAll = "[dbo].[uspUserReadAll]";

        public UserQueryRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<User> Read(long id)
        {
            User result = new User();

            using(var connection=new SqlConnection(DbConnectionString))
            {
                result = connection.Query<User>(uspUserRead, new { Id = id },
                    commandType: CommandType.StoredProcedure).First();
            }
            return result;
        }

        public async Task<IEnumerable<User>> ReadAllAsync()
        {
            IEnumerable<User> result;
            using(var connection=new SqlConnection(DbConnectionString))
            {
                result = await connection.QueryAsync<User>(uspUserReadAll);
            }
            return result;
        }
    }
}
