using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DummyQuizManager.Dal.Interface;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace DummyQuizManager.Service.Controllers
{
    [Route("api/[controller]")]
    public class QuestionsController : ControllerBase
    {
        public IQuestionsQueryRepository QuestionsQueryRepository { get; }

        public QuestionsController(IQuestionsQueryRepository questionsQueryRepository)
        {
            QuestionsQueryRepository = questionsQueryRepository;
        }

        [HttpGet("ReadAllQuestions")]
        public Task<IEnumerable<Questions>> ReadAllQuestions()

        {
            var result = this.QuestionsQueryRepository.ReadAllAsync();
            return result;
        }

        [HttpGet("ReadQuestionById/{id}")]
        public Task<Questions>ReadQuestionsById(int id)
        {
            var result = this.QuestionsQueryRepository.Read(id);
            return result;
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
