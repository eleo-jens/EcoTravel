using EcoTravel_BLL.Entities;
using EcoTravel_Common.Repositories;
using EcoTravel_MVC.Handlers;
using EcoTravel_MVC.Models.ModelViews.Proprietaire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Controllers
{
    public class ProprietaireController : Controller
    {

        private readonly ILogementRepository<Logement, int> _logementService;
        public ProprietaireController(ILogementRepository<Logement, int> logementService)
        {
            _logementService = logementService;
        }

        // GET: ProprietaireController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProprietaireController/Details/5
        public ActionResult Details(int id)
        {
            ProprietaireDetails model = new ProprietaireDetails();
            model.logements = _logementService.GetByProprietaire(id).Select(e => e.ToListItem());
            return View(model);
        }

        // GET: ProprietaireController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProprietaireController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProprietaireController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProprietaireController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProprietaireController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProprietaireController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
