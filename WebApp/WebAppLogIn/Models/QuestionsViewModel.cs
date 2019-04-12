using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace WebAppLogIn.Models
{
    public class QuestionsViewModel
    {
         public int Id { get; set; }
        public string Question { get; set; }
       
        public int CategoryId { get; set; }

        [DisplayName("Option A")]
        public string OptionA { get; set; }

        [DisplayName("Option B")]
        public string OptionB { get; set; }

        [DisplayName("Option C")]
        public string OptionC { get; set; }

        [DisplayName("Option D")]
        public string OptionD { get; set; }

        [Required(ErrorMessage ="Please insert an answer")]
        [RegularExpression("[A-Da-d ]*", ErrorMessage = "Invalid Name ")]
        public string Answer{ get; set; }
        public string Explanation{ get; set; }

        public int Total { get; set; }

        public List<Questions> ListOfQuestions { get; set; }
    }
}
