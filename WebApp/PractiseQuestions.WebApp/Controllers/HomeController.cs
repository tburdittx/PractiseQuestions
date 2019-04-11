using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PractiseQuestions.WebApp.Models;

namespace PractiseQuestions.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            this.GetMembers();
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

        public HttpResponseMessage httpClient()
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:40300/api/");

                //Called Member default GET All records  
                //GetAsync to send a GET request   
                // PutAsync to send a PUT request  
                var responseTask = client.GetAsync("questions/readallquestions");
                responseTask.Wait();

                //To store result of web api response.
                HttpResponseMessage result;
                 return  result = responseTask.Result;
            }
        }

        public ActionResult GetMembers()
        {
            IEnumerable<QuestionsViewModel> members = null;

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

                var result = this.httpClient();

                //If success received   
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<QuestionsViewModel>>();
                    readTask.Wait();

                    members = readTask.Result;
                }
                else
                {
                    //Error response received   
                    members = Enumerable.Empty<QuestionsViewModel>();
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            return View(members);
        }
    }
}
