using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DummyQuizManager.Dal.Interface;
using Entities;
using Microsoft.Extensions.Configuration;

namespace DummyQuizManager.Dal
{
    public class QuestionsQueryRepository : QueryRepositoryBase, IQuestionsQueryRepository
    {

        private const string uspQuestionsReadAll = "[dbo].[uspQuestionsReadAll]";
        private const string uspQuestionsRead = "[dbo].[uspQuestionsReadById]";
        
        public QuestionsQueryRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<Questions> Read(long id)
        {
            Questions result = new Questions();

            using (var connection = new SqlConnection(DbConnectionString))
            {
               // result = await connection.QueryFirstOrDefault<Questions>(uspQuestionsRead);

             //  result = await connection.QuerySingleAsync<Questions>(uspQuestionsRead, id).ConfigureAwait(false);

                 result = connection.Query<Questions>(uspQuestionsRead, new { Id = id },
        commandType: CommandType.StoredProcedure).First();
            }

            

            return result;

        }

        public async Task<IEnumerable<Questions>> ReadAllAsync()

        {  
                IEnumerable<Questions> result;

                using (var connection = new SqlConnection(DbConnectionString))
                {
                    result = await connection.QueryAsync<Questions>(uspQuestionsReadAll);
                }
                return result;            
        }
        
    }
}
