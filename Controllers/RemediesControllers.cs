using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EarthlyRemediesClient.Models;

namespace EarhtlyRemediesClient.Controllers
{
    public class RemediesController : Controller
    {
        [HttpGet("/index")]
        public IActionResult Index()
        {
            var allRemedies = Remedy.GetRemedies();
            return View(allRemedies);
        }

        public IActionResult Details(int id)
        {
            var remedy = Remedy.GetDetails(id);
            return View(remedy);
        
        }

        public IActionResult Edit(int id)
        {
            var remedy = Remedy.GetDetails(id);
            return View(remedy);
        }

        

        [HttpPost]
        public IActionResult Details(int id, Remedy remedy)
        {
            remedy.RemedyId = id;
            Remedy.Put(remedy);
            return RedirectToAction("Details", id);
        }
    }
        
}



    


