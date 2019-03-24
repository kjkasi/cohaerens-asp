using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cohaerens.Models;

namespace Cohaerens.Controllers
{
    public class AdminController : Controller
    {
        private IRepository repository;

        public AdminController(IRepository repo) => repository = repo;

        public IActionResult Index()
        {
            ViewBag.Title = "Admin panel";
            return View();
        }

        public IActionResult SysCom() => View(repository.SysComs);

        [HttpPost]
        public IActionResult AddSysCom(SysCom syscom)
        {
            repository.Add(syscom);
            return RedirectToAction(nameof(SysCom));
        }

        public IActionResult UpdateSysCom(long key)
        {
            return View(repository.GetSysCom(key));
        }

        [HttpPost]
        public IActionResult UpdateSysCom(SysCom syscom)
        {
            repository.Update(syscom);
            return RedirectToAction(nameof(SysCom));
        }

        [HttpPost]
        public IActionResult DeleteSysCom(SysCom syscom)
        {
            repository.Delete(syscom);
            return RedirectToAction(nameof(SysCom));
        }

        public IActionResult Place() => View(repository.Places);

        [HttpPost]
        public IActionResult AddPlace(Place place)
        {
            repository.Add(place);
            return RedirectToAction(nameof(Place));
        }

        public IActionResult UpdatePlace(long key)
        {
            return View(repository.GetPlace(key));
        }

        [HttpPost]
        public IActionResult UpdatePlace(Place place)
        {
            repository.Update(place);
            return RedirectToAction(nameof(Place));
        }

        [HttpPost]
        public IActionResult DeletePlace(Place place)
        {
            repository.Delete(place);
            return RedirectToAction(nameof(Place));
        }
    }
}
