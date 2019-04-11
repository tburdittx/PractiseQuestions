using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractiseQuestions.WebApp.Models
{
    public class QuestionsViewModel
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int CategoryId { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string Answer{ get; set; }
        public string Explanation{ get; set; }
    }
}
