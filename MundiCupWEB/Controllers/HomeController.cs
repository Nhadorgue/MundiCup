using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MundiCupWEB.Models;

namespace MundiCupWEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Distribute(List<Team> teams){
            int n =1;
            var teamsKey1 = new List<Team>();
            var teamsKey2 = new List<Team>();

            for (int i=0; i<teams.Count; i++)
            {
                if (n != 2)
                {
                    teamsKey1.Add(teams[i]);
                    n++;                     
                }else{
                    //teamsKey2.Add(teamsKey1);
                    n=1;               
                }           
            }
            //List<List<Team>>;
            return View("keys");
        }

        public IActionResult teamNames(int qtd){
            ViewData["qtd"] = qtd;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
