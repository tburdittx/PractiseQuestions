using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using WebAppLogIn.Models;

namespace WebAppLogIn.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult GetAllQuestionsByCategoryId()
        {
            // var result = GetAllQuestions();
            IEnumerable<QuestionsViewModel> questions;
            int id = 1;
            string readAllQuestionsUrl = $"questions/ReadQuestionByCategoryId/{id}";
            var result = this.httpClient(readAllQuestionsUrl);

            //If success received   
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<QuestionsViewModel>>();
                readTask.Wait();

                questions = readTask.Result;
            }
            else
            {
                //Error response received   
                questions = Enumerable.Empty<QuestionsViewModel>();
                ModelState.AddModelError(string.Empty, "Server error try after some time.");
            }

         

            return this.View("Questions",questions);
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public HttpResponseMessage httpClient(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:40300/api/");

                //Called Member default GET All records  
                //GetAsync to send a GET request   
                // PutAsync to send a PUT request  
                var responseTask = client.GetAsync(url);
                responseTask.Wait();

                //To store result of web api response.
                HttpResponseMessage result;
                return result = responseTask.Result;
            }
        }

        public IEnumerable<QuestionsViewModel> GetAllQuestions()
        {
            IEnumerable<QuestionsViewModel> questions = null;

            using (var client = new HttpClient())
            {
                /*
                client.BaseAddress = new Uri("http://localhost:40300/api/");

                //Called Member default GET All records  
                //GetAsync to send a GET request   
                // PutAsync to send a PUT request  
                var responseTask = client.GetAsync("questions/readallquestions");
                responseTask.Wait();

                //To store result of web api response.   
                var result = responseTask.Result;
                */
                string readAllQuestionsUrl = "questions/readallquestions";
                var result = this.httpClient(readAllQuestionsUrl);

                //If success received   
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<QuestionsViewModel>>();
                    readTask.Wait();

                    questions = readTask.Result;
                }
                else
                {
                    //Error response received   
                    questions = Enumerable.Empty<QuestionsViewModel>();
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
           return questions;
        }
    }
}
