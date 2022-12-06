using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using TravelsProject.Models;

namespace TravelsProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TravelsDBContext context;

        public HomeController(ILogger<HomeController> logger, TravelsDBContext _context)
        {
            _logger = logger;
            context = _context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult ShowList()
        {
            var TravelsList = context.BusInfos.ToList();
            return View(TravelsList);
        }

        public IActionResult Practice()
        {
            var lst = context.BusInfos.ToList();
            return View(lst);
        }

        [HttpGet]
        public IActionResult AddResult()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddResult(BusInfo busdata)
        {
            if (ModelState.IsValid)
            {
                context.BusInfos.Add(busdata);
                context.SaveChanges();
                TempData["Success"] = "Record Added Successfully";
                return RedirectToAction("ShowList");
            }
        return View(busdata);
        }



        public IActionResult EditRecord(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            var BusData = context.BusInfos.Find(id);

            if(BusData == null)
            {
                return NotFound();
            }
            return View(BusData);
        }

        [HttpPost]
        public IActionResult EditRecord(BusInfo BusData)
        {
            context.BusInfos.Update(BusData);
            context.SaveChanges();
            return RedirectToAction("ShowList");
        }

       
        public IActionResult DeleteRecord(int? id)
        {
            TempData["Success"] = "Record deleted Successfully";
            if(id == null || id == 0)
            {
                return NotFound();
            }

            var BusQueryData = context.BusInfos.Find(id);

            if(BusQueryData == null)
            {
                return NotFound();
            }

            if(BusQueryData != null)
            {
                context.BusInfos.Remove(BusQueryData);
                context.SaveChanges();
            }
            return RedirectToAction("ShowList");
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}