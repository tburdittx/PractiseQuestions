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
    public class QuestionsCommandRepository : CommandRepositoryBase//, IQuestionsCommandRepository
    {
        private const string UspQuestionsCreate = "[dbo].[uspQuestionsCreate]";
        private const string UspQuestionsDelete = "[dbo].[uspQuestionsDelete]";
        private const string UspQuestionsUpdate = "[dbo].[uspQuestionsUpdate]";

        public QuestionsCommandRepository(Lazy<IConfiguration> configuration) : base(configuration)
        {
        }

        public async Task<Questions> Create(Questions entity) 
        {
            var parameters = new
            {
                entity.Question,
                entity.OptionA,
                entity.OptionB,
                entity.OptionC,
                entity.OptionD,
                entity.Answer,
                entity.Explanation
            };

            Questions result = new Questions();
            using (var connection = new SqlConnection(DbConnectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute(UspQuestionsCreate, new { parameters });
                connection.Close();
               // return affectedRows;
            }
            return result;
          //  return await this.Create(this.DbConnectionString, UspQuestionsCreate, parameters).ConfigureAwait(false);
        }

        //public async Task<long> Delete(long id)
        //{
        //    var parameters = new
        //    {
        //        id
        //    };

        //    return await this.Delete(this.DbConnectionString, UspQuestionsDelete, id).ConfigureAwait(false);
        //}

        public async Task<long> Update(Questions entity)
        {
            var parameters = new
            {
                entity.Id,
                entity.Question,
                entity.OptionA,
                entity.OptionB,
                entity.OptionC,
                entity.OptionD,
                entity.Answer,
                entity.Explanation
            };

            return await this.Update(this.DbConnectionString, UspQuestionsUpdate, parameters).ConfigureAwait(false);
        }
    }
}
