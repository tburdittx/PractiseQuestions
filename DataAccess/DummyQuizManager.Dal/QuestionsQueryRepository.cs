using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Entities;
using Microsoft.Extensions.Configuration;
using PracticeQuestions.Dal.Interface;

namespace PracticeQuestions.Dal
{
    public class QuestionsQueryRepository : QueryRepositoryBase, IQuestionsQueryRepository
    {

        private const string uspQuestionsReadAll = "[dbo].[uspQuestionsReadAll]";
        private const string uspQuestionsRead = "[dbo].[uspQuestionsReadById]";
        private const string uspQuestionsReadByCategoryId = "[dbo].[uspQuestionsReadByCategoryId]";

        public QuestionsQueryRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<Questions> Read(long id)
        {
            Questions result = new Questions();

            using (var connection = new SqlConnection(DbConnectionString))
            {
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

        public async Task<IEnumerable<Questions>> ReadQuestionsByCategoryId(long id)
        {
            IEnumerable<Questions> result;

            using(var connection=new SqlConnection(DbConnectionString))
            {
                result = await connection.QueryAsync<Questions>(uspQuestionsReadByCategoryId, new { categoryId = id },
                commandType: CommandType.StoredProcedure);
            }
            return result;
        }
    }
}
