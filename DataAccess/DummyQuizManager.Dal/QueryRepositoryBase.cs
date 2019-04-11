using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace PracticeQuestions.Dal
{
    public class QueryRepositoryBase:QueryBaseRepository
    {
        private readonly IConfiguration configuration;

        private const string DbName = "PracticeQuestions";

        public QueryRepositoryBase(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IConfiguration Configuration => this.configuration;

        public string DbConnectionString => this.Configuration.GetConnectionString(DbName);

    }
}
