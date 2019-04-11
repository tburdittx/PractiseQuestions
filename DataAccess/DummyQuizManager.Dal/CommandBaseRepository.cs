using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeQuestions.Dal.Interface;

namespace PracticeQuestions.Dal
{
  public  abstract class CommandBaseRepository    
    {
        //public async Task<long> Create(string connectionstring, string sproc, object parameters)
        //{
          

        //  //  return await this.Create(this.DbConnectionString, UspQuestionsCreate, parameters).ConfigureAwait(false);
        //}

        //public async Task<long> Delete(long id)
        //{
        //    var parameters = new
        //    {
        //        id
        //    };

        //    return await this.Delete(this.DbConnectionString, UspQuestionsDelete, id).ConfigureAwait(false);
        //}

        public virtual Task<long> Update(string connectionString, string sprocName, object paramValues)
        {
            throw new NotImplementedException();
        }


    }
}
