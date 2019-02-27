using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApplication.Models;
using FirstApplication.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FirstApplication.Controllers
{
    public class MusicController : Controller
    {
        private readonly IBandRepository _bandRepository;
        public MusicController(IBandRepository bandRepository)
        {
            _bandRepository = bandRepository;
        }

        // GET: Music
        public ActionResult Index()
        {
            var bands = _bandRepository.GetBands();
            return View(bands);
        }

        // GET: Music/Details/5
        public ActionResult Details(int id)
        {
            var band = new Band
            {
                Title = "new title",
                Biography = "bio",
                Genre = "genre",
                Origin = "origin"
            };

            return View(band);
        }

        public JsonResult TestGetBand(int id)
        {
            var band = new Band
            {
                Title = "test title",
                Biography = "test bio",
                Genre = "test genre",
                Origin = "test origin"
            };

            return Json(JsonConvert.SerializeObject(band));
        }

        // GET: Music/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Music/Create
        [HttpPost]
        public ActionResult Create([FromBody]Band band)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Console.WriteLine("data is valid");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Music/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Music/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Music/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Music/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}