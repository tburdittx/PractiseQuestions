﻿using System.Collections.Generic;
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
    public class CategoryQueryRepository : QueryRepositoryBase, ICategoryQueryRepository
    {
        private const string uspCategoryRead = "[dbo].[uspCategoryRead]";
        private const string uspCategoryReadAll = "[dbo].[uspCategoryReadAll]";
        public CategoryQueryRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<Category> Read(long id)
        {
            Category result = new Category();

            using (var connection = new SqlConnection(DbConnectionString))
            {
                result = connection.Query<Category>(uspCategoryRead, new { Id = id },
                commandType: CommandType.StoredProcedure).First();
            }
            return result;
        }

        public async Task<IEnumerable<Category>> ReadAllAsync()
        {
            IEnumerable<Category> result;

            using (var connection = new SqlConnection(DbConnectionString))
            {
                result = await connection.QueryAsync<Category>(uspCategoryReadAll);
            }
            return result;
        }
    }
}
