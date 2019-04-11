using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeQuestions.Dal.Interface;
using PracticeQuestions.Dal;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace PracticeQuestions.Services
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IQuestionsQueryRepository, QuestionsQueryRepository>();
            services.AddMvc();

            services.AddSwaggerGen(c=> {
                c.SwaggerDoc("V1", new Info { Title = "", Version = "", Description = "", License = new License { } });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                var swaggerV1swaggerJson = "/swagger/v1/swagger.json";
                c.SwaggerEndpoint(swaggerV1swaggerJson, "Practise Questions API V1");
            });
        }
    }
}
