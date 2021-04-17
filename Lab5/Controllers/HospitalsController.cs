using System;
using System.Threading.Tasks;
using Lab5.Models;
using Lab5.ViewModels.Hospitals;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Controllers
{
    public class HospitalsController : Controller
    {
        private ApplicationDbContext _db;
        public HospitalsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _db.Hospitals.ToListAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(HospitalCreatingViewModel model)
        {
            if (ModelState.IsValid)
            {
                _db.Hospitals.Add(new Hospital()
                {
                    Name = model.Name,
                    Address = model.Address,
                    Phones = model.Phones
                });
                await _db.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Details(Guid id)
        {
            return View();
        }

        public IActionResult Edit(Guid id)
        {
            return View();
        }

        public IActionResult Delete(Guid id)
        {
            return View();
        }
    }
}
