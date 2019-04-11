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
    class SystemAdminQueryRepsitory : QueryRepositoryBase, ISystemAdminQueryRepository
    {
        private const string uspSystemAdminRead = "[dbo].[uspSystemAdminRead]";
        private const string uspSystemAdminReadAll = "[dbo].[uspSystemAdminReadAll]";
        public SystemAdminQueryRepsitory(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<SystemAdmin> Read(long id)
        {
            SystemAdmin result = new SystemAdmin();

            using(var connection=new SqlConnection(DbConnectionString))
            {
                result = connection.Query<SystemAdmin>(uspSystemAdminRead, new { Id = id },
                    commandType: CommandType.StoredProcedure).First();
            }
            return result;
        }

        public async Task<IEnumerable<SystemAdmin>> ReadAllAsync()
        {
            IEnumerable<SystemAdmin> result;

            using(var connection=new SqlConnection(DbConnectionString))
            {
                result = await connection.QueryAsync<SystemAdmin>(uspSystemAdminReadAll);
            }
            return result;
        }
    }
}
