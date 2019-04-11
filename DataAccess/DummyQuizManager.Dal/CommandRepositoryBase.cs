﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace PracticeQuestions.Dal
{
    public class CommandRepositoryBase: CommandBaseRepository
    {
        private readonly Lazy<IConfiguration> configuration;

        private const string DbName = "PracticeQuestions";

        public CommandRepositoryBase(Lazy<IConfiguration> configuration)
        {
            this.configuration = configuration;
        }

        public IConfiguration Configuration => this.configuration.Value;

        public string DbConnectionString => this.Configuration.GetConnectionString(DbName);
    }
}
